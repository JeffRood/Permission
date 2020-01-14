using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Permisos.Data;
using Permisos.Models;

namespace Permisos.Services
{
    public class PermissionServices
    {
        private readonly PermisoContext _context;

        public PermissionServices(PermisoContext _Services)
        {
            _context = _Services;
        }

        public Task<IEnumerable<Permiso>> GetAll()
        {
            return Task.Run(() =>
            {
                try
                {
                    //.OrderBy(v => v.Fecha).AsEnumerable()
                    return _context.Permisos.AsEnumerable();
                }
                catch (Exception exp)
                {

                    Console.WriteLine($"Error: { exp}");
                }
                return null;
            });
        }



        public Task<Permiso> GetById(int? id)
        {
            return Task.Run(() =>
            {

                if (id != null)
                {
                    try
                    {
                        var permiso = _context.Permisos.Where(v => v.Id == id).First();
                        if (permiso != null)
                        {
                            return permiso;
                        }
                    }
                    catch (Exception exp)
                    {

                        Console.WriteLine($"Error: { exp}");
                    }
                }
                return null;
            });

        }

        public Task<Permiso> Create(Permiso permiso)
        {
            return Task.Run(() =>
            {
                try
                {
                    _context.Permisos.Add(permiso);
                    _context.SaveChanges();
                    return permiso;
                }
                catch (Exception exp)
                {

                    Console.WriteLine($"Error: { exp}");

                }
                return null;
            });
        }

        public Task<Permiso> Delete(Permiso permiso)
        {
            return Task.Run(() =>
            {
                try
                {
                    _context.Permisos.Remove(permiso);
                    _context.SaveChanges();
                    return permiso;
                }
                catch (Exception exp)
                {

                    Console.WriteLine($"Error: { exp}");
                }
                return null;
            });
        }


        public Task<IEnumerable<TipoPermiso>> GetAllTipoPermisos()
        {
            return Task.Run(() =>
            {
                try
                {

                    return _context.TipoPermiso.OrderBy(v => v.Id).AsEnumerable();
                }
                catch (Exception exp)
                {

                    Console.WriteLine($"Error: { exp}");
                }
                return null;
            });
        }
    }
}
