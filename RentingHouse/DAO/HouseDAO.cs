﻿using RentingHouse.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentingHouse.DAO
{
    public class HouseDAO
    {
        private static HouseDAO instance;

        public static HouseDAO Instance
        {
            get { if (instance == null) instance = new HouseDAO(); return instance; }
            private set { instance = value; }
        }

        private HouseDAO() { }

        public DataTable GetAllHouses()
        {
            string query = string.Format("SELECT h.*, d.name, u.fullname FROM dbo.houses h JOIN dbo.districts d ON h.district_id = d.id JOIN dbo.users u ON h.h_user_id = u.id");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetListHouseById(List<int> listId)
        {
            string query = "SELECT h.*, d.name AS district, u.fullname FROM dbo.houses h JOIN dbo.districts d ON h.district_id = d.id JOIN dbo.users u ON h.h_user_id = u.id WHERE";
            foreach (int item in listId)
            {
                string str = string.Format(" h.id = {0} OR", item);
                query += str;
            }
            query = query.Substring(0, query.Length - 3);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetHousesByUserId(int id)
        {
            string query = string.Format("SELECT h.id, h.h_address, h.h_status, h.created_at, h.reason, d.name AS district FROM houses h JOIN districts d ON h.district_id = d.id WHERE h.h_user_id = {0}", id);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public House GetHouseById(int id)
        {
            House house = null;

            string query = "usp_XemChiTietNha @id";// cấu truy vấn gọi procedure

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {id});

            foreach (DataRow item in data.Rows)
            {
                house = new House(item);
                return house;
            }
            return house;
        }

        public bool RegisterHouse(House house)
        {
            //Sài query proc phải để param cách nhau như thế này "@a , @b" ko là bị lỗi
            int result = DataProvider.Instance.ExecuteNonQuery("usp_RegisterHouse @dientich , @gia , @songuoi , @diachi , @quan , @mota , @chunha",
                           new object[] { house.Area, house.Rental, house.NumberPeople, house.Address, house.District, house.Description, house.Owner });
            return result > 0;
        }

        public int InsertHouse(House h)
        {
            string query = string.Format($"INSERT INTO dbo.houses(area, rental, number_people, h_address, h_description, add_info, h_status, reason, district_id, h_user_id)" +
                $" VALUES({h.Area}, {h.Rental}, {h.NumberPeople}, {h.Address}, {h.Description}, {h.AddInfo} ,{h.Status}, {h.Reason}, {h.District}, {h.Owner})");

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }

        public int UpdateHouse(House h)
        {
            string query = string.Format($"UPDATE dbo.houses SET area = {h.Area}, rental = {h.Rental}, number_people = {h.NumberPeople}, h_address = {h.Address}, " +
                $"h_description = {h.Description}, add_info = {h.AddInfo}, h_status = {h.Status}, reason = {h.Reason}, district_id = {h.District}, h_user_id = {h.Owner} WHERE id = {h.Id}");

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }

        public int DeleteHouse(int id)
        {
            string query = string.Format("DELETE FROM dbo.houses WHERE id = {0}", id);

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }
    }
}
