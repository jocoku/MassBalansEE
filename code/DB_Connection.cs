using MassBalans.dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MassBalans
{
    public class DB_Connection
    {

        //  https://www.youtube.com/watch?time_continue=1&v=rohYqbIOG-Y&feature=emb_logo
        // https://codedocu.com/Net-Framework/WinForms/Winforms_colon_-Local-Database-create,-bind,-show-SELECT-INSERT-UPDATE-DELETE?2061

        SqlConnection cn_connection = new SqlConnection(Properties.Settings.Default.app_ConnectionString);

        #region MethodsResource
        // -----------< Fields and types of mbSources >-----------

        public DataTable resource_load_list(string table)
        {
            //--------------< Retrieve from database >------------- 
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            string sql_Text = "SELECT * FROM " + table;

            DataTable tbl = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(sql_Text, cn_connection);

            //--------------< Filling the response >-------------
            try
            {
                adapter.Fill(tbl);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            cn_connection.Close();
            return tbl;
        }

        public resourceDto resource_get_item(int code)
        {
            //--------------< send request to database >-------------
            resourceDto resource = new resourceDto();

            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            string sql_Text = "SELECT * FROM mbSources WHERE codeSource = " + code;

            DataSet dts = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter(sql_Text, cn_connection);

            //--------------< adapt response to fit rescourceDTO >-------------
            try
            {
                adapter.Fill(dts);

                DataRow ir = dts.Tables[0].Rows[0];

                string ir4 = "";
                int ir5 = 0;

                if (ir.ItemArray[2].GetType() == typeof(System.DBNull)) { ir4 = ""; } else { ir4 = (string)ir.ItemArray[2]; }
                if (ir.ItemArray[3].GetType() == typeof(System.DBNull)) { ir5 = 0; } else { ir5 = int.Parse(ir.ItemArray[3].ToString()); }

                resource = new resourceDto()
                {
                    codeSource = (int)ir.ItemArray[0],
                    name = (string)ir.ItemArray[1],
                    valueISCC = ir4,
                    classificationGroup = ir5
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            cn_connection.Close();
            return resource;
        }

        public void resource_new_entry(resourceDto addObject)
        {
            string sql_Text = "INSERT INTO mbSources ([codeSource], [Name], [nameISCC], [classificationGroup]) " +
                                    "VALUES(@codesource, @name, @nameiscc, @classificationgroup)";

            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
            cmd_Command.Parameters.Add("@codesource", SqlDbType.Int).Value = addObject.codeSource;
            cmd_Command.Parameters.Add("@name", SqlDbType.VarChar).Value = addObject.name;
            cmd_Command.Parameters.Add("@nameiscc", SqlDbType.NChar, 10).Value = addObject.valueISCC;
            cmd_Command.Parameters.Add("@classificationgroup", SqlDbType.VarChar, 5).Value = addObject.classificationGroup;

            cmd_Command.ExecuteNonQuery();

            cn_connection.Close();
        }

        public void resource_update_entry(resourceDto updObject)
        {
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            string sql_Text = "UPDATE mbSources SET [codeSource] = @codeSource, [name] = @name, [nameISCC] = @valueISCC, [classificationGroup] = @class " +
                                                    "WHERE codeSource = @codesource";

            SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
            cmd_Command.Parameters.Add("@codesource", SqlDbType.Int).Value = updObject.codeSource;
            cmd_Command.Parameters.Add("@name", SqlDbType.VarChar).Value = updObject.name;
            cmd_Command.Parameters.Add("@valueISCC", SqlDbType.VarChar).Value = updObject.valueISCC;
            cmd_Command.Parameters.Add("@class", SqlDbType.NChar).Value = updObject.classificationGroup;
            cmd_Command.ExecuteNonQuery();

            cn_connection.Close();
        }

        internal Dictionary <string, object> getPeriodInfo(DateTime activePeriod)
        {
            // get all mass balans variables and return them in a dict
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            // obtain quantity input and used resources per month
            string sql_Text = "SELECT SUM(quantity) as Amount, MONTH(DATE) as 'Month' FROM input WHERE MONTH(date) >= @beginMonth AND MONTH(date) <= @endMonth AND YEAR(DATE) = @year GROUP BY MONTH(date), conversion";

            SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
            cmd_Command.Parameters.Add("@beginMonth", SqlDbType.Int).Value = activePeriod.Month;
            cmd_Command.Parameters.Add("@endMonth", SqlDbType.Int).Value = activePeriod.Month+3;
            cmd_Command.Parameters.Add("@year", SqlDbType.Int).Value = activePeriod.Year;

            DataSet dts = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd_Command);

            //--------------< adapt response to fit in Dictionary >-------------
            try
            {
                adapter.Fill(dts);

                foreach (DataRow irs in dts.Tables[0].Rows)
                {
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            // get the year figures
            sql_Text = "SELECT SUM(quantity) as Amount FROM input WHERE YEAR(DATE) = @year GROUP BY conversion";

            cmd_Command = new SqlCommand(sql_Text, cn_connection);
            cmd_Command.Parameters.Add("@year", SqlDbType.Int).Value = activePeriod.Year;

            dts = new DataSet();

            adapter = new SqlDataAdapter(cmd_Command);

            //--------------< adapt response to fit in Dictionary >-------------
            try
            {
                adapter.Fill(dts);

                foreach (DataRow irs in dts.Tables[0].Rows)
                {
                    MessageBox.Show(irs.ItemArray[0] + "");
                    
                    MessageBox.Show(irs.ItemArray.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            int result = 0;
            try
            {
                result = Convert.ToInt32(cmd_Command.ExecuteScalar());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return new Dictionary<string, object>();
        }

        internal int get_resc_amount(int resourceValue, int producerValue) 
        {
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            string sql_Text = "SELECT SUM(quantity) as available FROM input WHERE supplier = @supplier AND resource = @resource";

            SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
            cmd_Command.Parameters.Add("@supplier", SqlDbType.Int).Value = producerValue;
            cmd_Command.Parameters.Add("@resource", SqlDbType.Int).Value = resourceValue;

            int result = 0;
            try
            {
                result = Convert.ToInt32(cmd_Command.ExecuteScalar());
            } catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return result;
        }

        public void resource_delete_entry(string ntaCode)
        {
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            string sql_Text = "DELETE FROM mbSources WHERE codeSource = " + ntaCode;
            SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
            cmd_Command.ExecuteNonQuery();

            cn_connection.Close();
        }

        #endregion MethodsResource

        #region Methods Input

        internal DataTable load_deliveries_dat(DateTime date)
        {
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            string sql_Text = "SELECT s.name as SUPPLIER, r.name as 'RESOURCE', SUM(quantity) as AMOUNT, SUM(truckneed) as TRUCKS, " +
                                        "SUM(truckfull) as 'FULL', SUM(truckempty) as 'EMPTY', MAX(i.date) as 'DATE' " +
                                        "FROM input i, supplier s, resource r " +
                                        "WHERE i.supplier = s.code AND i.resource = r.Id AND MONTH(i.date) = @MONTH AND YEAR(i.date) = @YEAR GROUP BY s.name, r.name";

            SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);

            cmd_Command.Parameters.Add("@MONTH", SqlDbType.Int).Value = date.Month;
            cmd_Command.Parameters.Add("@YEAR", SqlDbType.Int).Value = date.Year;

            DataTable tbl = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd_Command);

            //--------------< Filling the response >-------------
            try
            {
                adapter.Fill(tbl);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            cn_connection.Close();
            return tbl;
        }

        internal DataTable load_deliveries_pro(int supplier)
        {
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            string sql_Text = "SELECT r.name as name, i.resource as id FROM Input i, resource r WHERE i.resource = r.Id AND i.supplier = @supplier";
            SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
            cmd_Command.Parameters.Add("@supplier", SqlDbType.Int).Value = supplier;
            DataTable tbl = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd_Command);

            //--------------< Filling the response >-------------
            try
            {
                adapter.Fill(tbl);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            cn_connection.Close();
            return tbl;
        }


        internal DataTable load_deliveries_res(int resource)
        {
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            string sql_Text = "SELECT s.name as name, i.supplier as id FROM Input i, supplier s WHERE i.supplier = s.code AND i.resource = @resource";
            SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
            cmd_Command.Parameters.Add("@supplier", SqlDbType.Int).Value = resource;

            DataTable tbl = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd_Command);

            //--------------< Filling the response >-------------
            try
            {
                adapter.Fill(tbl);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            cn_connection.Close();
            return tbl;
        }

        public DataTable input_load_list(DateTime dateTime)
        {
            //--------------< Retrieve from database >------------- 
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            string sql_Text = "SELECT * FROM input WHERE [date] BETWEEN " + (dateTime.AddMonths(-1)) + " AND " + dateTime;

            DataTable tbl = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(sql_Text, cn_connection);

            //--------------< Filling the response >-------------
            try
            {
                adapter.Fill(tbl);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            cn_connection.Close();
            return tbl;
        }

        internal void delivery_save(inputDto inputObj)
        {
            MessageBox.Show(inputObj.orgCountry);
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            string sql_Text = "INSERT INTO input ([supplier], [resource], [conversion], [quantity], [truckneed], [truckfull], [truckempty], [orgCountry]) " +
                    "VALUES (@supplier, @resource, @conversion, @quantity, @truckneed, @truckfull, @truckempty, @orgCountry)";

            SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
            cmd_Command.Parameters.Add("@supplier", SqlDbType.Int).Value = inputObj.supplier;
            cmd_Command.Parameters.Add("@resource", SqlDbType.Int).Value = inputObj.resource;
            cmd_Command.Parameters.Add("@conversion", SqlDbType.Bit).Value = inputObj.conversion;
            cmd_Command.Parameters.Add("@quantity", SqlDbType.Int).Value = inputObj.quantity;
            cmd_Command.Parameters.Add("@truckneed", SqlDbType.Int).Value = inputObj.trucksneed;
            cmd_Command.Parameters.Add("@truckfull", SqlDbType.Int).Value = inputObj.truckFull;
            cmd_Command.Parameters.Add("@truckempty", SqlDbType.Int).Value = inputObj.truckEmpty;
            cmd_Command.Parameters.Add("@orgcountry", SqlDbType.VarChar).Value = inputObj.orgCountry;

            int numrows = cmd_Command.ExecuteNonQuery();
            MessageBox.Show(numrows + "");
        }

        #endregion Methods Input

        #region Methods Buyer

        public DataTable buyer_load_list(DateTime dateTime)
        {
            //--------------< Retrieve from database >------------- 
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            string sql_Text = "SELECT * FROM input WHERE [date] BETWEEN " + (dateTime.AddMonths(-1)) + " AND " + dateTime;

            DataTable tbl = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(sql_Text, cn_connection);

            //--------------< Filling the response >-------------
            try
            {
                adapter.Fill(tbl);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            cn_connection.Close();
            return tbl;
        }

        public clientDto buyer_get_one(string code)
        {
            //--------------< send request to database >-------------
            clientDto client = new clientDto();

            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            string sql_Text = "SELECT * FROM client WHERE code = " + code;

            DataSet dts = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter(sql_Text, cn_connection);

            //--------------< adapt response to fit rescourceDTO >-------------
            try
            {
                adapter.Fill(dts);

                DataRow ir = dts.Tables[0].Rows[0];

                client = new clientDto()
                {
                    code = (int)ir.ItemArray[0],
                    name = (string)ir.ItemArray[1],
                    country = (string)ir.ItemArray[2],
                    city = (string)ir.ItemArray[3],
                    zipCode = (string)ir.ItemArray[4],
                    street = (string)ir.ItemArray[5],
                    contract = (bool)ir.ItemArray[6]
                };

                if (ir.ItemArray[7].GetType() != typeof(System.DBNull))
                {
                    client.certVerto = (string)ir.ItemArray[7];
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            cn_connection.Close();
            return client;
        }

        public int client_update(clientDto updObject)
        {
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            string sql_Text = "UPDATE client SET [code] = @code, [name] = @name, [country] = @country, [city] = @city, " +
                "[zipCode] = @zip, [street] = @street, [contract] = @contract, [certVerto] = @verto WHERE code = @code";

            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
            cmd_Command.Parameters.Add("@code", SqlDbType.Int).Value = updObject.code;
            cmd_Command.Parameters.Add("@name", SqlDbType.VarChar).Value = updObject.name;
            cmd_Command.Parameters.Add("@country", SqlDbType.VarChar).Value = updObject.country;
            cmd_Command.Parameters.Add("@city", SqlDbType.VarChar).Value = updObject.city;
            cmd_Command.Parameters.Add("@zip", SqlDbType.NChar, 10).Value = updObject.zipCode;
            cmd_Command.Parameters.Add("@street", SqlDbType.VarChar, 50).Value = updObject.street;
            cmd_Command.Parameters.Add("@contract", SqlDbType.Bit).Value = updObject.contract;
            cmd_Command.Parameters.Add("@verto", SqlDbType.NChar, 10).Value = updObject.certVerto;

            int result = cmd_Command.ExecuteNonQuery();

            cn_connection.Close();

            return result;
        }

        #endregion Methods Buyer

        #region Supplier

        public supplierDto supplier_get_one(int code)
        {
            //--------------< send request to database >-------------
            supplierDto supplier = new supplierDto();

            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            string sql_Text = "SELECT s.*, sC.serial, sC.enddate FROM [supplier] AS s " +
                "OUTER APPLY " +
                "(SELECT TOP 1 serial, enddate FROM[supplierCert] c " +
                "WHERE c.supplierCode = s.code " +
                "ORDER BY c.enddate DESC) AS sC " +
                "WHERE s.code = " + code;

            DataSet dts = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter(sql_Text, cn_connection);

            //--------------< adapt response to fit rescourceDTO >-------------
            try
            {
                adapter.Fill(dts);

                DataRow ir = dts.Tables[0].Rows[0];

                supplier = new supplierDto()
                {
                    code = (int)ir.ItemArray[0],
                    name = (string)ir.ItemArray[1],
                    country = (string)ir.ItemArray[2],
                    city = (string)ir.ItemArray[3],
                    truckCap = (int)ir.ItemArray[4]
                };

                if (ir.ItemArray[5].GetType() != typeof(System.DBNull))
                {
                    supplier.certCode = (string)ir.ItemArray[5];
                    supplier.enddate = (DateTime)ir.ItemArray[6];
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            cn_connection.Close();
            return supplier;
        }

        public Boolean supplier_save(supplierDto updObject)
        {
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            int result = 0;

            SqlCommand commandRowCount = new SqlCommand(
                "SELECT COUNT(*) FROM dbo.supplier WHERE code = " + updObject.code + ";", cn_connection);
            long countEnd = Convert.ToInt32(commandRowCount.ExecuteScalar());

            if (countEnd == 0)
            {
                //string sql_Text = "INSERT INTO supplier ([code], [name], [country], [city]) " +
                //    "VALUES (@code, @name, @country, @city)";
                string sql_Text = "INSERT INTO supplier ([name], [country], [city], [truckSize]) " +
                    "VALUES (@name, @country, @city, @truckCap)";

                SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
                //cmd_Command.Parameters.Add("@code", SqlDbType.Int).Value = updObject.code;
                cmd_Command.Parameters.Add("@name", SqlDbType.VarChar).Value = updObject.name;
                cmd_Command.Parameters.Add("@country", SqlDbType.VarChar).Value = updObject.country;
                cmd_Command.Parameters.Add("@city", SqlDbType.VarChar).Value = updObject.city;
                cmd_Command.Parameters.Add("@truckCap", SqlDbType.Int).Value = updObject.truckCap;

                result = cmd_Command.ExecuteNonQuery();
            }
            else
            {
                string sql_Text = "UPDATE supplier SET [name] = @name, [country] = @country, [city] = @city, [truckSize] = @truckCap WHERE code = @code";

                SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
                cmd_Command.Parameters.Add("@code", SqlDbType.Int).Value = updObject.code;
                cmd_Command.Parameters.Add("@name", SqlDbType.VarChar).Value = updObject.name;
                cmd_Command.Parameters.Add("@country", SqlDbType.VarChar).Value = updObject.country;
                cmd_Command.Parameters.Add("@city", SqlDbType.VarChar).Value = updObject.city;
                cmd_Command.Parameters.Add("@truckCap", SqlDbType.Int).Value = updObject.truckCap;

                result = cmd_Command.ExecuteNonQuery();
            }

            cn_connection.Close();

            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal int get_truck_cap (int suppnum)
        {
            int num = 25000;

            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            string sql_Text = "SELECT truckSize FROM supplier WHERE code = @suppliercode";
            SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
            cmd_Command.Parameters.Add("@suppliercode", SqlDbType.Int).Value = suppnum;

            num = Convert.ToInt32(cmd_Command.ExecuteScalar());

            return num;
        }

        #endregion Supplier

        #region Certification

        public supplierCertDto certs_get_one(string serial)
        {
            //--------------< send request to database >-------------
            supplierCertDto cert = new supplierCertDto();

            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            string sql_Text = "SELECT sC.serial, sC.selfdec, sC.startdate, sC.enddate, s.name, sC.selfdecmeth FROM supplierCert AS sC " +
                "OUTER APPLY " +
                "(SELECT su.name FROM [supplier] su " +
                "WHERE su.code = sC.supplierCode) AS s " +
                "WHERE serial = '" + serial + "'";

            DataSet dts = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter(sql_Text, cn_connection);

            //--------------< adapt response to fit supplierCertDTO >-------------
            try
            {
                adapter.Fill(dts);

                DataRow ir = dts.Tables[0].Rows[0];

                cert = new supplierCertDto()
                {
                    serial = (string)ir.ItemArray[0],
                    selfdec = (bool)ir.ItemArray[1],
                    startdate = (DateTime)ir.ItemArray[2],
                    enddate = (DateTime)ir.ItemArray[3],
                    name = (string)ir.ItemArray[4],
                    selfdecmeth = (int)ir.ItemArray[5]
                };

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            cn_connection.Close();
            return cert;
        }

        internal bool save_cert(supplierCertDto updObject)
        {
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            SqlCommand commandRowCount = new SqlCommand(
                "SELECT COUNT(*) FROM dbo.supplierCert WHERE serial = @serial;", cn_connection);
            commandRowCount.Parameters.Add("@serial", SqlDbType.VarChar).Value = updObject.serial;
            long countEnd = Convert.ToInt32(commandRowCount.ExecuteScalar());

            if (countEnd >= 1)
            {
                string sql_Text = "UPDATE supplierCert SET [serial] = @serial, [selfdec] = @selfdec, " +
                    "[startdate] = @startdate, [enddate] = @enddate, [supplierCode] = @supplierCode, [selfdecmeth] = @selfdecmeth WHERE serial = @serial";

                SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
                cmd_Command.Parameters.Add("@serial", SqlDbType.VarChar).Value = updObject.serial;
                cmd_Command.Parameters.Add("@selfdec", SqlDbType.Bit).Value = updObject.selfdec;
                cmd_Command.Parameters.Add("@startdate", SqlDbType.DateTime).Value = updObject.startdate;
                cmd_Command.Parameters.Add("@enddate", SqlDbType.DateTime).Value = updObject.enddate;
                cmd_Command.Parameters.Add("@supplierCode", SqlDbType.Int).Value = updObject.supplierCode;
                cmd_Command.Parameters.Add("@selfdecmeth", SqlDbType.Int).Value = updObject.selfdecmeth;

                return (cmd_Command.ExecuteNonQuery() >= 1) ? true : false;
            }
            else
            {
                string sql_Text = "INSERT INTO supplierCert ([serial], [selfdec], [startdate], [enddate], [supplierCode], [selfdecmeth]) " +
                    "VALUES (@serial, @selfdec, @startdate, @enddate, @supplierCode, @selfdecmeth)";


                SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
                cmd_Command.Parameters.Add("@serial", SqlDbType.VarChar).Value = updObject.serial;
                cmd_Command.Parameters.Add("@selfdec", SqlDbType.Bit).Value = updObject.selfdec;
                cmd_Command.Parameters.Add("@startdate", SqlDbType.DateTime).Value = updObject.startdate;
                cmd_Command.Parameters.Add("@enddate", SqlDbType.DateTime).Value = updObject.enddate;
                cmd_Command.Parameters.Add("@supplierCode", SqlDbType.Int).Value = updObject.supplierCode;
                cmd_Command.Parameters.Add("@selfdecmeth", SqlDbType.Int).Value = updObject.selfdecmeth;

                int res = cmd_Command.ExecuteNonQuery();
                return (res >= 1);
            }
        }

        public bool check_certs(int compcode)
        {
            // lookup if company has current valid certificates
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            string sql_Text = "SELECT COUNT(*) FROM supplierCert WHERE startdate <= GETDATE() AND enddate >= GETDATE() AND supplierCode = @suppliercode";
            SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
            cmd_Command.Parameters.Add("@suppliercode", SqlDbType.Int).Value = compcode;

            int res = Convert.ToInt32(cmd_Command.ExecuteScalar());
            return ( res > 0 )?true : false;
        }

        #endregion Certification

        #region vertogas

        public void save_verto_info(DataTable information)
        {
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            using (SqlBulkCopy bulkCopy = new SqlBulkCopy(cn_connection))
            {
                bulkCopy.DestinationTableName =
                    "dbo.vertoValues";

                bulkCopy.ColumnMappings.Add("serialCert", "serialCert");
                bulkCopy.ColumnMappings.Add("quantity", "quantity");
                bulkCopy.ColumnMappings.Add("ntaCode", "ntaCode");
                bulkCopy.ColumnMappings.Add("transactionDate", "transactionDate");
                bulkCopy.ColumnMappings.Add("accountTo", "accountTo");

                try
                {
                    // Write unchanged rows from the source to the destination.
                    bulkCopy.WriteToServer(information);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                SqlCommand commandRowCount = new SqlCommand(
                "SELECT COUNT(*) FROM dbo.vertoValues;", cn_connection);
                long countEnd = Convert.ToInt32(commandRowCount.ExecuteScalar());
            }
        }

        #endregion vertogas

        #region Client

        public Boolean client_save(clientDto updObject)
        {
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            SqlCommand commandRowCount = new SqlCommand(
                "SELECT COUNT(*) FROM dbo.supplier WHERE code = " + updObject.code + ";", cn_connection);
            long countEnd = Convert.ToInt32(commandRowCount.ExecuteScalar());

            if (countEnd >= 1)
            {
                string sql_Text = "UPDATE client SET [code] = @code, [name] = @name, [country] = @country, [city] = @city, " +
                    "[zipCode] = @zip, [street] = @street, [contract] = @contract, [certVerto] = @verto WHERE code = @code";

                SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
                cmd_Command.Parameters.Add("@code", SqlDbType.Int).Value = updObject.code;
                cmd_Command.Parameters.Add("@name", SqlDbType.VarChar).Value = updObject.name;
                cmd_Command.Parameters.Add("@country", SqlDbType.VarChar).Value = updObject.country;
                cmd_Command.Parameters.Add("@city", SqlDbType.VarChar).Value = updObject.city;

                return (cmd_Command.ExecuteNonQuery() >= 1) ? true : false;
            }
            else
            {
                string sql_Text = "INSERT INTO client ([code], [name], [country], [city], [zipCode], [street], [contract], [certVerto]) " +
                    "VALUES (@code, @name, @country, @city, @zip, @street, @contract, @verto)";

                SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
                cmd_Command.Parameters.Add("@code", SqlDbType.Int).Value = updObject.code;
                cmd_Command.Parameters.Add("@name", SqlDbType.VarChar).Value = updObject.name;
                cmd_Command.Parameters.Add("@country", SqlDbType.VarChar).Value = updObject.country;
                cmd_Command.Parameters.Add("@city", SqlDbType.VarChar).Value = updObject.city;

                return (cmd_Command.ExecuteNonQuery() >= 1) ? true : false;
            }
        }

        #endregion Client

        #region Output

        public bool save_output( outputDto updObject)
        {
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            SqlCommand commandRowCount = new SqlCommand(
                "SELECT COUNT(*) FROM dbo.Output WHERE id = " + updObject.id + ";", cn_connection);
            long countEnd = Convert.ToInt32(commandRowCount.ExecuteScalar());

            if (countEnd >= 1)
            {
                string sql_Text = "UPDATE Output SET [id] = @id, [buyer] = @buyer, [quantity] = @quantity, [date] = @date WHERE id = @id";

                SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
                cmd_Command.Parameters.Add("@id", SqlDbType.Int).Value = updObject.id;
                cmd_Command.Parameters.Add("@buyer", SqlDbType.Int).Value = updObject.buyer;
                cmd_Command.Parameters.Add("@quantity", SqlDbType.Int).Value = updObject.quantity;
                cmd_Command.Parameters.Add("@date", SqlDbType.DateTime).Value = updObject.date;

                return (cmd_Command.ExecuteNonQuery() >= 1) ? true : false;
            }
            else
            {
                string sql_Text = "INSERT INTO Output ([buyer], [quantity], [date]) " +
                    "VALUES (@buyer, @quantity, @date)";
                

                SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
                cmd_Command.Parameters.Add("@buyer", SqlDbType.Int).Value = updObject.buyer;
                cmd_Command.Parameters.Add("@quantity", SqlDbType.Int).Value = updObject.quantity;
                cmd_Command.Parameters.Add("@date", SqlDbType.DateTime).Value = updObject.date;

                int res = cmd_Command.ExecuteNonQuery();
                return (res >= 1) ? true : false;
            }
        }

        public int available_gas()
        {
            int grand_total = 0;

            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            string sql_Text = "SELECT AVG(r.gasyield) as yield, SUM(i.quantity) as total FROM resource r, input i WHERE r.id = i.resource AND i.conversion = 1 GROUP BY i.resource";
            SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);

            DataTable tbl = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd_Command);

            //--------------< Filling the response >-------------
            try
            {
                adapter.Fill(tbl);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            foreach (DataRow dr in tbl.Rows)
            {
                grand_total += (int) dr.ItemArray[0] * ((int) dr.ItemArray[1] * -1) / 1000;
            }

            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            sql_Text = "SELECT COUNT(quantity) FROM Output";
            cmd_Command = new SqlCommand(sql_Text, cn_connection);
            grand_total -= Convert.ToInt32(cmd_Command.ExecuteScalar());

            return grand_total;
        }

        #endregion Output
    }
}


