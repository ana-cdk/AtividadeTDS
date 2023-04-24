using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurante.API.Models;

namespace Restaurante.API.Data
{
    public class DbInitializer
    {
        public static void Initialize(AppDbContext context){
                if(context.Mesas!.Any()){
                    return;
                }

                var mesas = new Mesa[]{
                        new Mesa{
                            Numero = 2,
                            Ocupada = false,
                            HoraAbertura = DateTime.Now
                        },
                };
                if(context.Garcons!.Any()){
                    return;
                }

                var garcons = new Garcon[]{
                        new Garcon{
                            Nome = "Marco",
                            Sobrenome = "false",
                            NumeroIdentificacao = "17",
                            NumeroTelefone = "1233456789"
                        },
                };
                if(context.Categorias!.Any()){
                    return;
                }

                var categorias = new Categoria[]{
                        new Categoria{
                            Nome = "Animal",
                            Descricao = "humano"
                        },
                };
                if(context.Produtos!.Any()){
                    return;
                }

                var produtos = new Produto[]{
                        new Produto{
                            Nome = "arroz",
                            Descricao = "Comida" ,
                            Preco = 3,
                        },

                };
                if(context.Atendimentos!.Any()){
                    return;
                }

                var atendimentos = new Atendimento[]{
                        new Atendimento{
                            HoraPedido = DateTime.Now
                        },
                };

                context.AddRange(mesas);
                context.SaveChanges();
        }
    }
}