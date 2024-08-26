
using System.Text.RegularExpressions;

namespace Ejercicio3.Entidades
{
    public static class ValidadorISBN
    {
        public static bool Validar(string isbn)
        {
            isbn = isbn.Trim();
            if(isbn.Length >10 && isbn.Length <13)
            {
                return false;
            }

            if(Formato13(isbn) || Formato10(isbn))
            {
                return true;
            }
            return false;
        }

        private static bool Formato10(string isbn)
        {
            string patron = @"\d{10}";
            return Regex.IsMatch(isbn, patron);
        }

        private static bool Formato13(string isbn)
        {
            string patron = @"\d{13}";
            return Regex.IsMatch(isbn, patron);
        }

        public static string EsValido(string isbn)
        {
            string formato10 = "de 10 digitos";
            string formato13 = "de 13 digitos.";
            if(Validar(isbn))
            {
                if(Formato13(isbn))
                {
                    return "Formato valido " + formato13;
                }
                //if(Formato13(isbn))
                //{
                //    return "Formato valido " + formato13;
                //}
                return "Formato valido " + formato10;

                
            }
            else
            {
                return "Formato invalido";
            }
        }
    }
}
