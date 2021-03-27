using Org.BouncyCastle.Asn1;
using ProductionManagementSystem.DataAccess;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ProductionManagementSystem.Security
{
    public enum StatusCode
    {
        Ok = 0,
        PeselNotFound = -1,
        UserNameTaken = -2,
        UnkonownError = -3,
        WrongCredentials = -4
    }

    public class CredentialManager
    {

        public CredentialManager()
        {

        }

        public StatusCode Login(string userName, string password, out int userId)
        {
            var hashedPassword = GetSHA256(password);
            
            int resultCode = DBManager.Instance.GetUserId(userName, hashedPassword);

            if (resultCode > 0)
            {
                userId = resultCode;
                return StatusCode.Ok;
            }

            userId = -1;
            return (StatusCode)resultCode;
        }

        //metoda zwraca user id, lub -1 w przypadku niepowodzenia
        public StatusCode RegisterUser(string pesel, string userName, string password)
        {
            int userId = DBManager.Instance.GetUserIdByPesel(pesel);
            //jeśli userId będzie -1 oznacza, że nie ma takiego peselu w bazie
            if (userId == -1) return StatusCode.PeselNotFound;

            bool userNameTaken = DBManager.Instance.LoginExists(userName);

            if (userNameTaken) return StatusCode.UserNameTaken;

            var hashedPassword = GetSHA256(password);

            StatusCode resultStatus = (StatusCode) DBManager.Instance.InsertUserCredentials(userId, userName, hashedPassword);
           
            return resultStatus;
        }

        private static string GetSHA256(string input)
        {
            var hasher = new SHA256Managed();
            var hash = new StringBuilder();
            byte[] crypto = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));

            foreach (byte theByte in crypto)
                hash.Append(theByte.ToString("x2"));

            return hash.ToString();
        }
    }
}
