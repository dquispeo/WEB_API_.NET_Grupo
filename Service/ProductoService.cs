using Domain;
using Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductoService
    {
        public List<Producto> Get()
        {
            List<Producto> students = null;
            using (var context = new SchoolContext())
            {
                productos = context.Productos.ToList();
            }
            return students;
        }

        public Producto GetById(int ID)
        {
            Producto student = null;
            using (var context = new SchoolContext())
            {
                productos = context.Productos.Find(ID);
            }
            return student;
        }

        public void Insert(Producto student)
        {
            using (var context = new SchoolContext())
            {
                context.Productos.Add(producto);
                context.SaveChanges();
            }
        }

        public void Update(Producto student, int ID)
        {
            using (var context = new SchoolContext())
            {
                var productoNew = context.Productos.Find(ID);
                productoNew.codigo = producto.codigo;
                productoNew.precio = producto.precio;
                productoNew.stok = producto.stok;
                productoNew.enable = producto.enable;    
    
                context.SaveChanges();
            }
        }

        public void Delete(int ID)
        {
            using (var context = new SchoolContext())
            {
                var producto = context.Productos.Find(ID);
                context.Productos.Remove(producto);
                context.SaveChanges();
            }
        }

    }
}
