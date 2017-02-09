using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OOPSHeadStart;

namespace Shapes
{
    interface IShape
    {
        ShapeType GetShapeType();
    }

    abstract class Shape : IShape
    {
        protected ShapeType shapeType;
        
        public ShapeType GetShapeType()
        {
            return shapeType;
        }
    }

    /// <summary>
    /// This is a representation of circle shape
    /// </summary>
    class Circle: Shape
    {
        #region Fields
        Single _radius;
        Point _center;
        #endregion


        #region Behaviour
        /// <summary>
        /// Calculates Area of circle
        /// </summary>
        /// <returns>Area of circle</returns>
        public double Area()
        {
            return Math.PI * _radius * _radius;
        }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Circle()
        {
            _radius = -1;
        }

        /// <summary>
        /// Consturctor
        /// </summary>
        /// <param name="radius">Radius</param>
        public Circle(float radius)
        {
            _radius = radius;
        }
        #endregion

    }

    #region tempo
    //class AccessModifiers
    //{
    //    int i;
    //    protected int j;
    //    public int k;
    //    internal int l;
    //    protected internal int m;

    //    public void ini()
    //    {
    //        i = j = k = l = m = 10;
    //    }
    //}

    //class child : AccessModifiers
    //{
    //    public void ini()
    //    {
    //        j = k = l = m = 10;
    //    }
    //} 
    #endregion
}
