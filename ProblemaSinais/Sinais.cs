using Dominio.Entities;
using Dominio.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProblemaSinais
{
    public class Sinais : ISinais
    {
        public IEnumerable<DadosSinais> ValidarSinais(string[] dados)
        {
            try
            {
                var listaRetorno = new List<DadosSinais>();
                foreach (string s in dados)
                {
                    if (!string.IsNullOrWhiteSpace(s))
                    {
                        var retornoSinal = new DadosSinais()
                        {
                            Caracteres = s
                        };

                        if (s.Count() % 2 != 0 || !Regex.IsMatch(s, @"^[\[\]\{\}\(\)]+$"))
                            retornoSinal.Balanceado = false;
                        else
                            retornoSinal.Balanceado = ValidarBalanceamento(s);

                        listaRetorno.Add(retornoSinal);
                    }
                }

                return listaRetorno;
            }
            catch
            {
                return new List<DadosSinais>();
            }
        }

        private bool ValidarBalanceamento(string s)
        {

            for (int i = 0; i < s.Count(); i++)
            {
                int indexUltimoChar = s.Count() - 1;

                if (s[i].ToString() == "{" && s.Substring(indexUltimoChar) != "}")
                    return false;

                if (s[i].ToString() == "[" && s.Substring(indexUltimoChar) != "]")
                    return false;

                if (s[i].ToString() == "(" && s.Substring(indexUltimoChar) != ")")
                    return false;

                s = s.Remove(indexUltimoChar);
            }

            return true;
        }
    }
}
