using Backend.AccesoDatos;
using Backend.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Logica
{/*
    public class LogCicloMenstrual
    {
        public ResIngresarCicloMenstrual IngresarCicloMenstrual(ReqIngresarCicloMenstrual req)
        { 
            ResIngresarCicloMenstrual res = new ResIngresarCicloMenstrual();
            try
            {
                if (LogSession.ErroresSession(req.session)) 
                { 
                    res.resultado = false;
                    res.errorCode = (int)EnumErrores.SessionInvalida;
                    res.errorMensaje = "Session Invalida";
                }
                else if (req.elcicloMenstrual.FechaInicioCiclo == null)
                {
                    res.resultado = false;
                    res.errorCode = (int)EnumErrores.FechaFaltante;
                    res.errorMensaje = "Fecha Faltante";
                }
                else if (req.elcicloMenstrual.DuracionCiclo == 0)
                {
                    res.resultado = false;
                    res.errorCode = (int)EnumErrores.DuracionCicloFaltante;
                    res.errorMensaje = "Duracion Ciclo Faltante";
                }
                else if (req.elcicloMenstrual.DuracionMenstruacion == 0)
                {
                    res.resultado = false;
                    res.errorCode = (int)EnumErrores.DuracionMenstrualFaltante;
                    res.errorMensaje = "Duracion Menstruacion Faltante";
                }
                else
                {
                    //LLEGARON TODOS LOS DATOS
                    //Enviar a base de datos
                    int? errorId = 0;
                    int? idReturn = 0;//idusuario
                    string errorDescripcion = "";
                    int? userId = LogSession.obtenerSession(req.session).Session_User_Id;
                    conexionlinqDataContext miLinq = new conexionlinqDataContext();
                    miLinq.sp_IngresarRegistroCicloMenstrual(userId, req.elcicloMenstrual.FechaInicioCiclo, req.elcicloMenstrual.DuracionCiclo, req.elcicloMenstrual.DuracionMenstruacion, ref idReturn, ref errorId, ref errorDescripcion);
                    if (errorId == 0 && idReturn != 0)
                    {
                        res.resultado = true;

                    }
                    else
                    {
                        res.resultado = false;
                        res.errorCode = (int)EnumErrores.ErrorCicloMenstrual;
                        res.errorMensaje = "Error Ciclo Menstrual";
                        Console.WriteLine(errorDescripcion);
                    }
                }
            }
            catch (Exception ex) 
            {
                res.resultado = false;
                res.errorCode = (int)EnumErrores.ErrorInterno;
                res.errorMensaje = "Error Interno";
                Console.WriteLine(ex.Message);  
            }
            return res;
        }

        public ResObtenerUnCicloMenstrual obtenerUnCicloMenstrual(ReqObteneUnCicloMenstrual req)
        {
            ResObtenerUnCicloMenstrual res = new ResObtenerUnCicloMenstrual();
            try
            {
                int? errorId = 0;
                int? idReturn = 0;//idusuario
                string errorDescripcion = "";
                if (LogSession.ErroresSession(req.session))
                {
                    res.resultado = false;
                    res.errorCode = (int)EnumErrores.SessionInvalida;
                    res.errorMensaje = "Session Invalida";
                }
                else 
                {
                    int? userId = LogSession.obtenerSession(req.session).Session_User_Id;
                    conexionlinqDataContext miLinq = new conexionlinqDataContext();
                    List<sp_ObtenerCicloMenstrualResult> miListaDeLinq = new List<sp_ObtenerCicloMenstrualResult>();
                    miListaDeLinq = miLinq.sp_ObtenerCicloMenstrual(userId, ref idReturn, ref errorId, ref errorDescripcion).ToList();
                    if (errorId == 0 )
                    {
                        res.ListaDeCiclomenstrual = this.armarListaUnCicloMenstrual(miListaDeLinq);
                    }
                    else
                    {
                        Console.WriteLine("Error al obtener la ciclo. Descripción del error: " + errorDescripcion);
                        res.resultado = false;
                    }
                }

            } catch (Exception ex)
            {
                res.resultado = false;
                res.errorCode = (int)EnumErrores.ErrorInterno;
                res.errorMensaje = "Error Interno";
                Console.WriteLine(ex.Message);
            }
            return res;
        }


        private List<CicloMenstrual> armarListaUnCicloMenstrual(List<sp_ObtenerCicloMenstrualResult> ListaDeCicloMenstrualLinq)
        {
            
            List<CicloMenstrual> listaDevolver = new List<CicloMenstrual>();

            foreach (sp_ObtenerCicloMenstrualResult cadaLinq in ListaDeCicloMenstrualLinq)
            {
                CicloMenstrual miCicloMenstrual = new CicloMenstrual();

                // Asegúrate de asignar un valor a la propiedad DuracionCiclo
                miCicloMenstrual.DuracionCiclo = cadaLinq.CICMENS_DURACION_CICLO;
                miCicloMenstrual.DuracionMenstruacion = cadaLinq.CICMENS_DURACION_MENSTRUACION;
                miCicloMenstrual.FechaInicioCiclo = (DateTime)cadaLinq.CICMENS_FECHA_INICIO_CICLO;

                listaDevolver.Add(miCicloMenstrual);
            }

            return listaDevolver;
        }
           

    }*/
}
