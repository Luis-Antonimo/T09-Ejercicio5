using System;

namespace T09_Ejercicio5
{
    class Libro
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro();
            libro1.setInfoLibro("Cervantes", "El Quijote", "Novela");
            Console.WriteLine(libro1.getInfoLibro());

            Libro libro2 = new Libro();
            libro2.setInfoLibro("George Orwell", "1984", "Novela");
            Console.WriteLine(libro2.getInfoLibro());
        }

        private string autor;
        private string titulo;
        private string ubicacion;


        //Constructor vacío. Lo pongo aunque no hace falta -creo-.
        public Libro()
        {
        }

        public void setInfoLibro(string autorCambio, string tituloCambio, string ubicacionCambio)
        {
            autor = autorCambio;
            titulo = tituloCambio;
            ubicacion = ubicacionCambio;
        }

        public string getInfoLibro()
        {
            return "\nAutor: " + autor + "\nTitulo: " + titulo + "\nUbicación: " + ubicacion;
        }
    }
}