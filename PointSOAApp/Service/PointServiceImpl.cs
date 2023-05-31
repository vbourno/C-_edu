using PointSOAApp.DAO;
using PointSOAApp.DTO;
using PointSOAApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointSOAApp.Service
{
    internal class PointServiceImpl : IPointService
    {
        private readonly IPointDAO? dao;

        public PointServiceImpl(IPointDAO? pointDAO)
        {
            this.dao = pointDAO;
        }

        public void InsertPoint(PointDTO dto)
        {
            Point point = new Point() { X = dto.X };
            dao?.Insert(point);
        }

        public bool UpdatePoint(PointDTO dto, int x)
        {
            Point point = new Point() { X = dto.X };
            return (bool)(dao?.Update(point, x));
        }

        public Point? DeletePoint(PointDTO dto)
        {
            Point point = new Point() { X= dto.X };
            return dao?.Delete(point);
        }

        public List<Point>? GetAllPoints()
        {
            //return dao?.GetAll();
            return PointDAOImpl.Points;
        }

        public Point? GetPoint(PointDTO dto)
        {
            Point point = new Point() { X = dto.X};
            return dao.GetOnePoint(point);
        }

        

        
    }
}
