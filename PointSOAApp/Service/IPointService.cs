using PointSOAApp.DTO;
using PointSOAApp.Model;
using System;
using System.Collections.Generic;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointSOAApp.Service
{
    internal interface IPointService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        public void InsertPoint(PointDTO dto);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        /// <param name="x"></param>
        public bool UpdatePoint(PointDTO dto, int x);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Point? DeletePoint(PointDTO dto);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Point? GetPoint(PointDTO dto);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Point>? GetAllPoints();
    }
}
