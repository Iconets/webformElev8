using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace webformElev8
{
   
        public class EmployeesInfo
        {
            public int TrId { get; set; }
            public string Surname { get; set; }
            public string OtherNames { get; set; }
            public string Gender { get; set; }
            public string MobileNo { get; set; }
            public string EmailAddress { get; set; }
            public string Address { get; set; }
            public DateTime DateEmployed { get; set; }
            public DateTime DateofBirth { get; set; }
        }
        class DataClass
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Elev8Connection"].ConnectionString;


            //when creating a method using a variable string or int you have return the value at the end of the method created except is a void
            public int CreateEmployeeRecord(EmployeesInfo employeesInfo)

            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        //Insert into [TableName](Properties) Values(content)
                        String query = "INSERT INTO EmployeesDetails(Surname,OtherNames,Gender, MobileNo,EmailAddress,Address,DateEmployed,DateofBirth) Values(@Surname,@OtherNames,@Gender, @MobileNo,@EmailAddress,@Address,@DateEmployed,@DateofBirth)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            //command.Parameters.AddWithValue("@TrId", TrId);
                            command.Parameters.AddWithValue("@Surname", employeesInfo.Surname);
                            command.Parameters.AddWithValue("@OtherNames", employeesInfo.OtherNames);
                            command.Parameters.AddWithValue("@Gender", employeesInfo.Gender);
                            command.Parameters.AddWithValue("@MobileNo", employeesInfo.MobileNo);
                            command.Parameters.AddWithValue("@EmailAddress", employeesInfo.EmailAddress);
                            command.Parameters.AddWithValue("@Address", employeesInfo.Address);
                            command.Parameters.AddWithValue("DateEmployed", employeesInfo.DateEmployed);
                            command.Parameters.AddWithValue("@DateofBirth", employeesInfo.DateofBirth);
                            connection.Open();
                            int result = command.ExecuteNonQuery();

                            return result;
                            // Check Error
                           // if (result < 0)
                           /* {
                                Console.WriteLine("Error inserting data into Database!");
                            }
                            else
                            {
                            // MessageBox.Show("Record Added Successfully.");
                            //bttnread.PerformClick();
                            return 1;
                            }*/


                        }
                    }

                }
                catch (Exception ex)
                {
                   // MessageBox.Show(ex.Message);
                    //this means action is not successful
                    return -1;
                }
                //this means it action is successful
               
            }


            public DataTable ReadEmployeeRecord()
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    String sql = "SELECT * FROM EmployeesDetails";

                    SqlCommand sqlcom = new SqlCommand(sql, connection);
                    try
                    {
                        sqlcom.Connection.Open();
                        sqlcom.ExecuteNonQuery();
                        SqlDataReader reader = sqlcom.ExecuteReader();

                        dt.Load(reader);
                        //dgView.DataSource = datatable;
                        //MessageBox.Show("LEFT OUTER);
                    }
                    catch (SqlException ex)
                    {
                       // MessageBox.Show(ex.Message);
                    }
                }

                return dt;
            }

            public int UpdateEmployeeRecord(EmployeesInfo employeesInfo)
            {
                int result = -1;
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        //Update [TableName] set Property=@Value where PK=?
                        String query = "Update EmployeesDetails set  Surname=@Surname,OtherNames=@OtherNames,Gender=@Gender, MobileNo=@MobileNo, EmailAddress=@EmailAddress, Address=@Address, DateEmployed=@DateEmployed, DateofBirth=@DateofBirth where TrId=@TrId";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@TrId", employeesInfo.TrId);
                            command.Parameters.AddWithValue("@Surname", employeesInfo.Surname);
                            command.Parameters.AddWithValue("@OtherNames", employeesInfo.OtherNames);
                            command.Parameters.AddWithValue("@Gender", employeesInfo.Gender);
                            command.Parameters.AddWithValue("@MobileNo", employeesInfo.MobileNo);
                            command.Parameters.AddWithValue("@EmailAddress", employeesInfo.EmailAddress);
                            command.Parameters.AddWithValue("@Address", employeesInfo.Address);
                            command.Parameters.AddWithValue("DateEmployed", employeesInfo.DateEmployed);
                            command.Parameters.AddWithValue("@DateofBirth", employeesInfo.DateofBirth);
                            connection.Open();
                            result = command.ExecuteNonQuery();

                            // Check Error
                            if (result < 0)
                            {
                                Console.WriteLine("Error Updating data in Database!");
                            }
                            else
                            {
                                //MessageBox.Show("Record Updated Successfully.");
                                //bttnread.PerformClick();
                            }


                        }
                    }

                }
                catch (Exception ex)
                {
                   // MessageBox.Show(ex.Message);
                    throw;
                }
                return result;
            }

            public int DeleteEmployeeRecord(EmployeesInfo employeesInfo)
            {
                int result = -1;
                //if (MessageBox.Show("Are you sure you want to Delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {

                            //"Delete from [TableName] where Primary key=@Primary key"; 
                            String query = "DELETE from EmployeesDetails where TrId=@TrId";


                            using (SqlCommand command = new SqlCommand(query, connection))


                            {
                                command.Parameters.AddWithValue("@TrId", employeesInfo.TrId);
                                connection.Open();
                                result = command.ExecuteNonQuery();
                                connection.Close();

                                // Check Error
                                if (result < 0)
                                {
                                    Console.WriteLine("Error Deleting data in Database!");
                                }
                                else
                                {
                                    //MessageBox.Show("Trainee Record Deleted Successfully.");
                                    //clear();
                                    //bttnread.PerformClick();

                                }
                            }
                        }



                    }


                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.Message);
                    }


                }
                return 0;
            }



        }
    
}