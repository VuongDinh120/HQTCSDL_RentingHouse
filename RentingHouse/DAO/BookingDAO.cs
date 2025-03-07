﻿using RentingHouse.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentingHouse.DAO
{
    class BookingDAO
    {
        private static BookingDAO instance;

        public static BookingDAO Instance
        {
            get { if (instance == null) instance = new BookingDAO(); return instance; }
            private set { instance = value; }
        }

        private BookingDAO() { }

        public Booking GetBookingById(int id)
        {
            Booking b = null;

            string query = string.Format("SELECT * FROM dbo.booking WHERE id = {0}", id);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                b = new Booking(item);
                return b;
            }
            return b;
        }

        public float GetBookingLiaFeeById(int id)
        {
            Booking b = null;

            string query = string.Format("SELECT * FROM dbo.booking WHERE id = {0}", id);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                b = new Booking(item);
                return b.LiabilityFee;
            }
            return 0;
        }
        public DataTable GetBookingByUserId(int id)
        {
            string query = string.Format("SELECT id, begin_date, end_date, received_date, b_status, number_house, liability_fee, rent_fee FROM dbo.booking WHERE b_user_id = {0}", id);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetAllBooking()
        {
            string query = string.Format("SELECT id, begin_date=CONVERT(varchar,begin_date,105), end_date=convert(varchar,end_date,105), received_date = isnull(convert(nvarchar(10),received_date,105), N'Chưa nhận'), b_status, number_house, liability_fee, rent_fee, b_user_id FROM dbo.booking");
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int InsertBooking(Booking b)
        {
            string query = string.Format($"INSERT INTO dbo.booking(begin_date, end_date, b_status, number_house, rent_fee, liability_fee, b_user_id) VALUES ({b.BeginDate}, {b.EndDate}, N'{b.Status}', {b.NumberHouse}, {b.RentFee}, {b.LiabilityFee}, {b.UserId});");
            //System.Windows.Forms.MessageBox.Show(query, "insert booking", System.Windows.Forms.MessageBoxButtons.OK);
            query += " SELECT CAST(scope_identity() AS int)";

            int idInserted = (int)DataProvider.Instance.ExecuteScalar(query);
                
            return idInserted;
        }

        public int UpdateBooking(Booking b)
        {
            string query = string.Format($"UPDATE dbo.booking SET begin_date = {b.BeginDate}, end_date = {b.EndDate}, b_status = {b.Status}, number_house = {b.NumberHouse}," +
                $" rent_fee = {b.RentFee}, liability_fee = {b.LiabilityFee}, b_user_id = {b.UserId} WHERE id = {b.Id}");

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }

        public int DeleteBooking(int id)
        {
            string query = string.Format("DELETE FROM dbo.booking WHERE id = {0}", id);

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }
    }
}
