using System;
// Es este laboratorio Titulado  "Blog".
// Se basa en el proceso de la expresion, 
// la cual es la oportunidad de simular opiniones (post) y comentarios
//pero sin de momento la posibilidad de poder editar o modificar los comentarios del post
//requiero una pantalla principal(Main) la cual funcionara con 2 viewmodel. asociadas a 2 controladores
//(uno para Post y Otro para comment) 
// la ENTIDAD OBJETO ABSTRACTA  sera llamada "expresion", y constan de 2 propiedades o constantes; ,
// el datetime y el contenido ( constantes en todo Blog o sistema de posts comments)
// se definira al momento de realizar el uso de la interfaz, ahi se selecciona que base de datos
// y viewmodel usaran(ya DEFINIDAS y updatean) , en base a que pantalla realizan la accion Es decir
// new post, editar post y eliminar post y mostrar posts iran en el viewmodel 1 y la base de datos 1,
// osea 3 pantallas 
// el viewmodel 2 y la base de datos 2 esta pensada para usar las expresiones como comentarios
// y almacenarlos asociados obvio por al ID y categoria de la basededatos 1, seran buscados por la abstracta datetime para hacer match
// las bases de datos deberian estar interelacionadas por el ID del Post que se comento,
// con las "categorias abiertas" en vez de limitadas.


namespace LaboratorioSemana2
{
    public class Main_cs { }
    public abstract class Expresion
    {
public DateTime Tiempo { get => Tiempo; set => Tiempo = value; }
public String Contenido;

        protected Expresion(DateTime tiempo, string contenido)
        {
            Tiempo = tiempo;
            Contenido = contenido;
        }
    } 

       
    } 







