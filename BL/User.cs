using System.Globalization;

namespace BL
{
    public class User
    {
        //public static ML.Result AddLQ(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (DL.BvaguilarProgramacionNcapasNetcoreContext context = new DL.BvaguilarProgramacionNcapasNetcoreContext())
        //        {
        //            DL.Usuario usuariolq = new DL.Usuario();
        //            DateTime FechaDeNacimiento = DateTime.ParseExact(usuario.FechaDeNacimiento, "dd-MM-yyyy", CultureInfo.InvariantCulture); // para tranformar una fecha de un string a un DATETIME
        //            ObjectParameter IdUsuario = new ObjectParameter("IdUsuario", typeof(int));
        //            string Sexo = char.ToString(usuario.Sexo);



        //            //usuariolq.IdUsuario = usuario.IdUsuario;
        //            usuariolq.Nombre = usuario.Nombre;
        //            usuariolq.Curp = usuario.urp;
        //            usuariolq.Password = usuario.Password;
        //            usuariolq.CorreoElectronico = usuario.CorreoElectronico;
        //            usuariolq.FechaDeNacimiento = FechaDeNacimiento;
        //            //usuariolq.Direccion = usuario.Direccion;
        //            usuariolq.Telefono = usuario.Telefono;
        //            usuariolq.ApellidoPaterno = usuario.ApellidoPaterno;
        //            usuariolq.ApellidoMaterno = usuario.ApellidoMaterno;
        //            usuariolq.Sexo = Sexo; // Sexo.Replace(" ", "")
        //            usuariolq.Celular = usuario.Celular;
        //            usuariolq.Curp = usuario.Curp;
        //            usuariolq.IdRol = usuario.Rol.IdRol;
        //            //usuariolq.IdUsuarioModificacion = usuario.IdUsuarioModificacion;
        //            usuariolq.Imagen = usuario.Imagen;

        //            context.Usuarios.Add(usuariolq);
        //            int rowsAffectes = context.SaveChanges();

        //            result.Correct = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;
        //}

        //public static ML.Result UpdateLQ(ML.Usuario usuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (DL_EF.BVAguilarProgramacionNCapasEntities context = new DL_EF.BVAguilarProgramacionNCapasEntities())
        //        {
        //            var query = (from a in context.Usuarios
        //                         where a.IdUsuario == usuario.IdUsuario
        //                         select a).SingleOrDefault();

        //            if (query != null) //se valida si el usuario existe
        //            {
        //                DateTime FechaDeNacimiento = DateTime.ParseExact(usuario.FechaDeNacimiento, "dd-MM-yyyy", CultureInfo.InvariantCulture); // para tranformar una fecha de un string a un DATETIME
        //                string Sexo = char.ToString(usuario.Sexo);


        //                query.IdUsuario = usuario.IdUsuario;
        //                query.Nombre = usuario.Nombre;
        //                query.UserName = usuario.UserName;
        //                query.Password = usuario.Password;
        //                query.CorreoElectronico = usuario.CorreoElectronico;
        //                query.FechaDeNacimiento = FechaDeNacimiento;
        //                //query.Direccion = usuario.Direccion;
        //                query.Telefono = usuario.Telefono;
        //                query.ApellidoPaterno = usuario.ApellidoPaterno;
        //                query.ApellidoMaterno = usuario.ApellidoMaterno;
        //                query.Sexo = Sexo;
        //                query.Celular = usuario.Celular;
        //                query.Curp = usuario.Curp;
        //                query.IdRol = usuario.Rol.IdRol;
        //                query.FechaModificacion = DateTime.Now; //para la fecha de ahora
        //                //query.IdUsuarioModificacion = usuario.IdUsuarioModificacion;
        //                query.Imagen = usuario.Imagen;

        //                context.SaveChanges();

        //                result.Correct = true;

        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "No se encontró el usuario" + usuario.IdUsuario;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;
        //}

        //public static ML.Result DeleteLQ(int IdUsuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (DL_EF.BVAguilarProgramacionNCapasEntities context = new DL_EF.BVAguilarProgramacionNCapasEntities())
        //        {
        //            var query = (from a in context.Usuarios
        //                         where a.IdUsuario == IdUsuario
        //                         select a).First();

        //            if (query != null) //se valida si el usuario existe
        //            {
        //                context.Usuarios.Remove(query);

        //                context.SaveChanges();

        //                result.Correct = true;

        //            }
        //            else
        //            {
        //                result.Correct = false;
        //                result.ErrorMessage = "No se encontró el usuario" + IdUsuario;
        //            }


        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;
        //}

        //public static ML.Result GetAllLQ()
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (DL_EF.BVAguilarProgramacionNCapasEntities context = new DL_EF.BVAguilarProgramacionNCapasEntities())
        //        {
        //            var innerJoinQuery = (from a in context.Usuarios
        //                                  join rol in context.Rols on a.IdRol equals rol.IdRol
        //                                  select new
        //                                  {
        //                                      IdUsuario = a.IdUsuario,
        //                                      Nombre = a.Nombre,
        //                                      UserName = a.UserName,
        //                                      Password = a.Password,
        //                                      CorreoElectronico = a.CorreoElectronico,
        //                                      FechaDeNacimiento = a.FechaDeNacimiento,
        //                                      //Direccion = a.Direccion,
        //                                      Telefono = a.Telefono,
        //                                      ApellidoPaterno = a.ApellidoPaterno,
        //                                      ApellidoMaterno = a.ApellidoMaterno,
        //                                      Sexo = a.Sexo,
        //                                      Celular = a.Celular,
        //                                      Curp = a.Curp,
        //                                      IdRol = rol.IdRol,
        //                                      Rol = rol.Nombre,
        //                                      FechaCreacion = a.FechaCreacion,
        //                                      FechaModificacion = a.FechaModificacion,
        //                                      IdUsuarioModificacion = a.IdUsuarioModificacion,
        //                                      Imagen = a.Imagen,
        //                                      Status = a.Status
        //                                  }).ToList();

        //            result.Objects = new List<object>();

        //            if (innerJoinQuery != null && innerJoinQuery.ToList().Count > 0)
        //            {
        //                foreach (var objeto in innerJoinQuery)
        //                {
        //                    ML.Usuario usuario = new ML.Usuario();

        //                    usuario.IdUsuario = objeto.IdUsuario;
        //                    usuario.Nombre = objeto.Nombre;
        //                    usuario.UserName = objeto.UserName;
        //                    usuario.Password = objeto.Password;
        //                    usuario.CorreoElectronico = objeto.CorreoElectronico;
        //                    usuario.FechaDeNacimiento = objeto.FechaDeNacimiento.ToString("dd-MM-yyyy");
        //                    usuario.Telefono = objeto.Telefono;
        //                    usuario.ApellidoPaterno = objeto.ApellidoPaterno;
        //                    usuario.ApellidoMaterno = objeto.ApellidoMaterno;

        //                    usuario.Sexo = char.Parse(objeto.Sexo.Replace(" ", ""));
        //                    //usuario.Sexo = objeto.Sexo;
        //                    usuario.Celular = objeto.Celular;
        //                    usuario.Curp = objeto.Curp;
        //                    usuario.Rol = new ML.Rol(); //instancia para rol  
        //                    usuario.Rol.IdRol = (objeto.IdRol != null) ? objeto.IdRol : byte.Parse("0"); //
        //                    usuario.Rol.Nombre = objeto.Rol;
        //                    usuario.FechaCreacion = (objeto.FechaCreacion != null) ? objeto.FechaCreacion.Value.ToString("dd-MM-yyyy HH:mm:ss") : null;
        //                    usuario.FechaModificacion = (objeto.FechaModificacion != null) ? objeto.FechaModificacion.Value.ToString("dd-MM-yyyy HH:mm:ss") : null;
        //                    usuario.IdUsuarioModificacion = (objeto.IdUsuarioModificacion != null) ? objeto.IdUsuarioModificacion.Value : byte.Parse("0");
        //                    usuario.Imagen = objeto.Imagen;
        //                    usuario.Status = objeto.Status.Value;

        //                    result.Objects.Add(usuario);
        //                }
        //                result.Correct = true;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;
        //}

        //public static ML.Result GetByIdLQ(int IdUsuario)
        //{
        //    ML.Result result = new ML.Result();
        //    try
        //    {
        //        using (DL_EF.BVAguilarProgramacionNCapasEntities context = new DL_EF.BVAguilarProgramacionNCapasEntities())
        //        {
        //            var query = (from a in context.Usuarios
        //                         join rol in context.Rols on a.IdRol equals rol.IdRol
        //                         where a.IdUsuario == IdUsuario
        //                         select new
        //                         {
        //                             IdUsuario = a.IdUsuario,
        //                             Nombre = a.Nombre,
        //                             UserName = a.UserName,
        //                             Password = a.Password,
        //                             CorreoElectronico = a.CorreoElectronico,
        //                             FechaDeNacimiento = a.FechaDeNacimiento,
        //                             //Direccion = a.Direccion,
        //                             Telefono = a.Telefono,
        //                             ApellidoPaterno = a.ApellidoPaterno,
        //                             ApellidoMaterno = a.ApellidoMaterno,
        //                             Sexo = a.Sexo,
        //                             Celular = a.Celular,
        //                             Curp = a.Curp,
        //                             IdRol = rol.IdRol,
        //                             //Rol = rol.Nombre,
        //                             FechaCreacion = a.FechaCreacion,
        //                             FechaModificacion = a.FechaModificacion,
        //                             IdUsuarioModificacion = a.IdUsuarioModificacion,
        //                             Imagen = a.Imagen
        //                         }).FirstOrDefault();

        //            //result.Objects = new List<object>();

        //            if (query != null)
        //            {
        //                ML.Usuario usuario = new ML.Usuario();

        //                usuario.IdUsuario = query.IdUsuario;
        //                usuario.Nombre = query.Nombre;
        //                usuario.UserName = query.UserName;
        //                usuario.Password = query.Password;
        //                usuario.CorreoElectronico = query.CorreoElectronico;
        //                usuario.FechaDeNacimiento = query.FechaDeNacimiento.ToString("dd-MM-yyyy");
        //                //usuario.Direccion = query.Direccion;
        //                usuario.Telefono = query.Telefono;
        //                usuario.ApellidoPaterno = query.ApellidoPaterno;
        //                usuario.ApellidoMaterno = query.ApellidoMaterno;
        //                string Sexo = query.Sexo;
        //                usuario.Sexo = char.Parse(Sexo.Replace(" ", ""));
        //                //usuario.Sexo = query.Sexo;
        //                usuario.Celular = query.Celular;
        //                usuario.Curp = query.Curp;
        //                usuario.Rol = new ML.Rol(); //instancia para rol  
        //                usuario.Rol.IdRol = (query.IdRol != null) ? query.IdRol : byte.Parse("0");
        //                //usuario.Rol.Nombre = query.Rol;
        //                usuario.FechaCreacion = (query.FechaCreacion != null) ? query.FechaCreacion.Value.ToString("dd-MM-yyyy HH:mm:ss") : null;
        //                usuario.FechaModificacion = (query.FechaModificacion != null) ? query.FechaModificacion.Value.ToString("dd-MM-yyyy HH:mm:ss") : null;
        //                usuario.IdUsuarioModificacion = (query.IdUsuarioModificacion != null) ? query.IdUsuarioModificacion.Value : byte.Parse("0");
        //                usuario.Imagen = query.Imagen;

        //                result.Object = usuario;
        //                result.Correct = true;
        //            }
        //            else
        //            {

        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result.Correct = false;
        //        result.ErrorMessage = ex.Message;
        //    }
        //    return result;
        //}







    }
}