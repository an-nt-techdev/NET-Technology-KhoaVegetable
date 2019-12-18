﻿using ASP.NET_CORE_Final_2019.Models;
using ASP.NET_CORE_Final_2019.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_CORE_Final_2019.Repository
{
    public class SanphamRepository : IFSanpham
    {
        private VEGEFOOD_DBContext db;

        public SanphamRepository(VEGEFOOD_DBContext _db)
        {
            db = _db;
        }


            // Loại sản phẩm
        public Loaisanpham GetLoaiSanPham(int Id)
        {
            Sanpham a = GetSanPham(Id);
            Loaisanpham res = db.Loaisanpham.Find(a.IdLoaiSanPham);
            return res;
        }
        public IEnumerable<Loaisanpham> GetLoaiSanPhams => db.Loaisanpham;
            // Thêm - sửa - xóa
        public void addLoaiSanPham(Loaisanpham _Loaisanpham)
        {
            db.Loaisanpham.Add(_Loaisanpham);
            db.SaveChanges();
        }
        public void updateLoaiSanPham(Loaisanpham _Loaisanpham)
        {
            db.Loaisanpham.Update(_Loaisanpham);
            db.SaveChanges();
        }
        public void removeLoaiSanPham(int Id)
        {
            Loaisanpham res = db.Loaisanpham.Find(Id);
            db.Loaisanpham.Remove(res);
            db.SaveChanges();
        }


            // Sản phẩm
        public Sanpham GetSanPham(int Id)
        {
            Sanpham res = db.Sanpham.Find(Id);
            return res;
        }
        public IEnumerable<Sanpham> GetSanPhams => db.Sanpham;
        public IEnumerable<Sanpham> Get8SanPhams()
        {
            IEnumerable<Sanpham> list = GetSanPhams;
            int num = list.Count() / 6;
            int i = 0;
            foreach (Sanpham item in list)
            {
                i++;
                if (i == 1) yield return item;
                else if (i == list.Count()-1) yield return item;
                else
                {
                    if (i == num) yield return item;
                    else if (i == num * 2) yield return item;
                    else if (i == num * 3) yield return item;
                    else if (i == num * 4) yield return item;
                    else if (i == num * 5) yield return item;
                    else if (i == num * 6) yield return item;
                }
            }
            
        }
            // Thêm - sửa - xóa
        public void addSanPham(Sanpham _Sanpham)
        {
            db.Sanpham.Add(_Sanpham);
            db.SaveChanges();
        }
        public void updateSanPham(Sanpham _Sanpham)
        {
            db.Sanpham.Update(_Sanpham);
            db.SaveChanges();
        }
        public void removeSanPham(int Id)
        {
            Sanpham res = db.Sanpham.Find(Id);
            db.Sanpham.Remove(res);
            db.SaveChanges();
        }


            // Chi tiết sản phẩm
        public Chitietsanpham GetChiTietSanPham(int Id)
        {
            Chitietsanpham res = db.Chitietsanpham.Find(Id);
            return res;
        }
        public IEnumerable<Chitietsanpham> GetChiTietSanPhams => db.Chitietsanpham;

            // Thêm - sửa - xóa
        public void addChiTietSanPham(Chitietsanpham _Chitietsanpham)
        {
            db.Chitietsanpham.Add(_Chitietsanpham);
            db.SaveChanges();
        }
        public void updateChiTietSanPham(Chitietsanpham _Chitietsanpham)
        {
            db.Chitietsanpham.Update(_Chitietsanpham);
            db.SaveChanges();
        }
        public void removeChiTietSanPham(int Id)
        {
            Chitietsanpham res = db.Chitietsanpham.Find(Id);
            db.Chitietsanpham.Remove(res);
            db.SaveChanges();
        }

    }
}