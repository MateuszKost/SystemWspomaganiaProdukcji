using MySql.Data.MySqlClient;
using ProductionManagementSystem.Controllers;
using ProductionManagementSystem.Models;
using ProductionManagementSystem.Security;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ProductionManagementSystem.DataAccess
{
    //Singleton pattern
    public class DBManager
    {

        #region private members

        private MySqlConnection connection;
        private static DBManager instance = null;
        private static readonly object synclock = new object();
        private static readonly string connectionString = "Server=remotemysql.com;Port=3306;Database=jpcfvyP3J2;Uid=jpcfvyP3J2;Pwd=is9ERbctyf;";

        #endregion

        #region constructors

        protected DBManager()
        {
            connection = new MySqlConnection(connectionString);
        }

        #endregion

        #region public properties and methods

        public static DBManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synclock)
                    {
                        if (instance == null) instance = new DBManager();
                    }
                }
                return instance;
            }
        }

        public void Ping()
        {
            //TODO
        }


        public int GetUserId(string login, string hashedPassword)
        {
            connection.Open();

            var statement = $"SELECT user_id FROM employee_credentials WHERE login = '{login}' AND password = '{hashedPassword}'";
            var command = new MySqlCommand(statement, connection);
            try
            {
                int userId = -1;
                var reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    connection.Close();
                    return -4;
                }
                while (reader.Read())
                {
                    userId = reader.GetInt32("user_id");
                }
                connection.Close();
                return userId;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                connection.Close();
            }
            return -3;
        }

        public int GetUserIdByPesel(string pesel)
        {
            connection.Open();

            int userId = (int)StatusCode.PeselNotFound;

            var statement = $"SELECT user_id FROM employees WHERE pesel = '{pesel}'";
            var command = new MySqlCommand(statement, connection);
            try
            {
                var reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    connection.Close();
                    return userId;
                }
                while (reader.Read())
                {
                    userId = reader.GetInt32("user_id");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                connection.Close();
            }

            connection.Close();

            return userId;
        }

        public int InsertUserCredentials(int userId, string login, string password)
        {
            connection.Open();

            var statement = $"INSERT INTO employee_credentials VALUES ({userId}, '{login}', '{password}')";
            var command = new MySqlCommand(statement, connection);
            try
            {
                if (command.ExecuteNonQuery() != 1)
                {
                    connection.Close();
                    return -3;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                connection.Close();
                return -3;
            }

            connection.Close();

            return 0;
        }

        public bool LoginExists(string login)
        {
            connection.Open();

            var statement = $"SELECT COUNT(*) FROM employee_credentials WHERE login = '{login}'";
            var command = new MySqlCommand(statement, connection);

            try
            {
                int result = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                if (result > 0) return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                connection.Close();
            }

            connection.Close();

            return false;
        }

        public Employee GetUserById(int id)
        {
            connection.Open();

            var statement = $"SELECT * FROM employees WHERE user_id = '{id}'";
            var command = new MySqlCommand(statement, connection);


            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();

                var employee = new Employee
                {
                    UserId = reader.GetInt32(0),
                    TypeId = reader.GetInt32(1),
                    Name = reader.GetString(2),
                    LastName = reader.GetString(3),
                    Pesel = reader.GetString(4),
                    DateOfBirth = reader.GetDateTime(5),
                    PlaceOfResidence = reader.GetString(6),
                    DepartmentId = reader.GetInt32(7)
                };

                reader.Close();
                connection.Close();
                return employee;
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message, "Błąd");
                Console.WriteLine(e.Message);
            }

            connection.Close();
            return null;
        }

        public int InsertEmployeeForm(DateTime date, int createdParts, int norm, int calculatedPoints)
        {
            connection.Open();
            Employee currentUser = BaseController.Instance.CurrentEmployee;


            var workerStatInsertion = $"INSERT INTO worker_statistics (amount,user_id,department_id,date,norm,prize_points) VALUES ({createdParts},{currentUser.UserId},{currentUser.DepartmentId},'{date.ToString("yyyy-MM-dd")}',{norm},{calculatedPoints})";
            var command = new MySqlCommand(workerStatInsertion, connection);
            try
            {
                if (command.ExecuteNonQuery() != 1)
                {
                    connection.Close();
                    return -3;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                connection.Close();
                return -3;
            }
            connection.Close();

            return 0;
        }
      
        public Department GetDepartmentById(int departmentId)
        {
            connection.Open();
          /*  Employee currentEmployee = global.GetInstance().GetCurrentUser();
            List<EmployeeForm> tmpFormList = new List<EmployeeForm>();*/
            var workerStatInsertion = $"SELECT * FROM departments WHERE department_id = {departmentId}";
            MySqlCommand command = new MySqlCommand(workerStatInsertion, connection);

            var reader = command.ExecuteReader();
            reader.Read();
            Department userDepartment = new Department();
            userDepartment.DepartmentId = reader.GetInt32(0);    //department id                 
            userDepartment.DepartmentName = reader.GetString(1); // department name
            userDepartment.PartName = reader.GetString(2);          // part id 
            userDepartment.MinimalAmount = reader.GetInt32(3);
            connection.Close();
            return userDepartment;

        }

        public List<Department> GetAllDepartmets()
        {
            connection.Open();
            var query = $"SELECT * FROM departments";
            MySqlCommand command = new MySqlCommand(query, connection);
            var list = new List<Department>();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Department userDepartment = new Department();
                userDepartment.DepartmentId = reader.GetInt32(0);    //department id                 
                userDepartment.DepartmentName = reader.GetString(1); // department name
                userDepartment.PartName = reader.GetString(2);          // part name            
                userDepartment.MinimalAmount = reader.GetInt32(3);  //minimal amount
                list.Add(userDepartment);
            }
            connection.Close();
            return list;
        }

        public List<Employee> GetEmployeesList(int departmentId)
        {
            connection.Open();
            List<Employee> newList = new List<Employee>();

            var workerStatInsertion = $"SELECT * FROM employees WHERE department_id = {departmentId} and type_id = {3}";
            MySqlCommand command = new MySqlCommand(workerStatInsertion, connection);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var employee = new Employee
                {
                    UserId = reader.GetInt32(0),
                    TypeId = reader.GetInt32(1),
                    Name = reader.GetString(2),
                    LastName = reader.GetString(3),
                    Pesel = reader.GetString(4),
                    DateOfBirth = reader.GetDateTime(5),
                    PlaceOfResidence = reader.GetString(6),
                    DepartmentId = reader.GetInt32(7),
                };

                newList.Add(employee);
            }
            connection.Close();
            return newList;

        }

        public List<EmployeeTable> GetEmployeeForm(int userId)
        {
            connection.Open();
        
            List<EmployeeTable> tmpFormList = new List<EmployeeTable>();
            var workerStatInsertion = $"SELECT * FROM worker_statistics WHERE user_id = {userId}";
            MySqlCommand command = new MySqlCommand(workerStatInsertion, connection);
          
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    EmployeeTable tmpEmpForm = new EmployeeTable();
                    tmpEmpForm.Date = reader.GetString(2);                    //date
                    tmpEmpForm.Date = tmpEmpForm.Date.Remove(10);
                    tmpEmpForm.Amount = int.Parse(reader.GetString(3));     //amount
                    tmpEmpForm.Norm = int.Parse(reader.GetString(4));       //norm
                    tmpEmpForm.PrizePoints = int.Parse(reader.GetString(5));//prize

                    tmpFormList.Add(tmpEmpForm);
                }

            connection.Close();
            return tmpFormList;
        }

        public int GetLastMonthParts(int userId)
        {
            connection.Open();

            var statement = $"SELECT SUM(amount) FROM worker_statistics WHERE user_id = {userId} AND MONTH(date) = MONTH(NOW()) AND YEAR(date) = YEAR(NOW())";
            MySqlCommand command = new MySqlCommand(statement, connection);

            var reader = command.ExecuteReader();
            reader.Read();
            int sum = reader.GetInt32(0);

            connection.Close();

            return sum;
        }

        public int GetDepartmentStatistics(int depId, string period)
        {
            connection.Open();
            string statement;
            // ZMIENIĆ TO NA ENUM
            switch (period)
            {
                case "day":
                    statement = $"SELECT SUM(amount) FROM worker_statistics WHERE department_id = {depId} AND date = DATE_FORMAT(NOW(),'%Y%m%d')";
                    break;
                case "month":
                    statement = $"SELECT SUM(amount) FROM worker_statistics WHERE department_id = {depId} AND MONTH(date) = MONTH(NOW()) AND YEAR(date) = YEAR(NOW())";
                    break;
                case "year":
                    statement = $"SELECT SUM(amount) FROM worker_statistics WHERE department_id = {depId} AND YEAR(date) = YEAR(NOW())";
                    break;
                default: statement = $"SELECT SUM(amount) FROM worker_statistics WHERE department_id = {depId}";
                    break;

            }

            MySqlCommand command = new MySqlCommand(statement, connection);

            try
            {
                var reader = command.ExecuteReader();
                int sum;
                reader.Read();
                if (!reader.IsDBNull(0))
                    sum = reader.GetInt32(0);
                else
                    sum = 0;

                connection.Close();
                return sum;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                connection.Close();
                return -3;
            }

        }

        public int GetTheTakenPrizePoints(int userId)
        {
            connection.Open();

            var statement = $"SELECT SUM(prize_cost) FROM taken_prizes WHERE user_id = {userId}";
            MySqlCommand command = new MySqlCommand(statement, connection);

            var reader = command.ExecuteReader();
            reader.Read();

            int sum2;
            if (reader.IsDBNull(0))
            {
                sum2 = 0;
            }
            else
            {
                sum2 = reader.GetInt32(0);
            }

            connection.Close();

            return sum2;

        }
        public int SumThePrizePoints(int userId)
        {
            connection.Open();

            var statement = $"SELECT SUM(prize_points) FROM worker_statistics WHERE user_id = {userId} AND YEAR(date) = YEAR(NOW())";
            MySqlCommand command = new MySqlCommand(statement, connection);

            var reader = command.ExecuteReader();
            reader.Read();

            int sum = reader.GetInt32(0);

            //int sum = 0;

            connection.Close();

            int sum2 = GetTheTakenPrizePoints(userId);

            return sum - sum2;
        }

        public int InsertEmployee(Employee newEmployee)
        {
            connection.Open();
            var date = newEmployee.DateOfBirth.ToString("yyyy-MM-dd");
            var workerStatInsertion = $"INSERT INTO employees (name,last_name,type_id,pesel,date_of_birth,address,department_id) VALUES ('{newEmployee.Name}','{newEmployee.LastName}',{newEmployee.TypeId},'{newEmployee.Pesel}','{date}','{newEmployee.PlaceOfResidence}',{newEmployee.DepartmentId})";
            var command = new MySqlCommand(workerStatInsertion, connection);
            try
            {
                if (command.ExecuteNonQuery() != 1)
                {
                    connection.Close();
                    return -3;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                connection.Close();
                return -3;
            }
            connection.Close();

            return 0;
        }

        public List<Prize> GetPrizesList(int userId)
        {
            connection.Open();
            List<Prize> newList = new List<Prize>();

            var workerStatInsertion = $"SELECT * FROM prizes";
            MySqlCommand command = new MySqlCommand(workerStatInsertion, connection);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var prize = new Prize
                {
                    PrizeId = reader.GetInt32(0),
                    PrizeName = reader.GetString(1),
                    RequiredPoints = reader.GetInt32(2)
                };

                newList.Add(prize);
            }
            connection.Close();
            return newList;

        }

        public void DeleteEmployee(Employee employee)
        {
            connection.Open();
            var statement = $"DELETE FROM employee_credentials WHERE user_id = { employee.UserId }";
            var command = new MySqlCommand(statement, connection);
            try
            {
                if (command.ExecuteNonQuery() != 1)
                {
                    connection.Close();
                }
            }
            catch
            {
                MessageBox.Show("Nie można było usunąć pracownika");
                connection.Close();
            }
            connection.Close();
        }

        /**
         * 
         * Move employee from one department to another
         */
        public void MoveEmployee(Employee employee, int newDepartmentId)
        {
            connection.Open();
            var statement = $"UPDATE employees SET department_id = { newDepartmentId } where user_id = { employee.UserId }";
            var command = new MySqlCommand(statement, connection);
            try
            {
                if (command.ExecuteNonQuery() != 1)
                {
                    connection.Close();
                }
            }
            catch
            {
                MessageBox.Show("Nie można było przenieść pracownika");
                connection.Close();
            }
            connection.Close();
        }


        public int InsertPrize(Prize newPrize)
        {
            connection.Open();
            var workerStatInsertion = $"INSERT INTO prizes( prize_name, required_points) VALUES ('{newPrize.PrizeName}',{newPrize.RequiredPoints})";
            var command = new MySqlCommand(workerStatInsertion, connection);
            try
            {
                if (command.ExecuteNonQuery() != 1)
                {
                    connection.Close();
                    return -3;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                connection.Close();
                return -3;
            }
            connection.Close();

            return 0;
        }

        public List<TakenPrize> GetTakenPrizesList(int usertId)
        {
            connection.Open();
            List<TakenPrize> newList = new List<TakenPrize>();

            var workerStatInsertion = $"SELECT * FROM taken_prizes";
            MySqlCommand command = new MySqlCommand(workerStatInsertion, connection);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var prize = new TakenPrize
                {
                   UserId = reader.GetInt32(0),
                   PrizeId = reader.GetInt32(1),
                   PrizeCost = reader.GetInt32(2)
                };

                newList.Add(prize);
            }
            connection.Close();
            return newList;

        }

        public int InsertTakenPrize(TakenPrize newTakenPrize)
        {
            connection.Open();
            var workerStatInsertion = $"INSERT INTO taken_prizes(user_id,prize_id,prize_cost) VALUES ({newTakenPrize.UserId},{newTakenPrize.PrizeId},{newTakenPrize.PrizeCost})";
            //var workerStatInsertion = $"INSERT INTO worker_statistics (amount,user_id,department_id,date,norm,prize_points) VALUES ({createdParts},{currentUser.UserId},{currentUser.DepartmentId},'{date.ToString("yyyy-MM-dd")}',{0},{0})";
            var command = new MySqlCommand(workerStatInsertion, connection);
            try
            {
                if (command.ExecuteNonQuery() != 1)
                {
                    connection.Close();
                    return -3;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                connection.Close();
                return -3;
            }
            connection.Close();

            return 0;
        }

        #endregion
    } 

}
