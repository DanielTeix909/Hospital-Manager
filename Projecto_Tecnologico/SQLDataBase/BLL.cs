using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    public class BLL
    {
        public class funcionarios
        {

            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from empregados", null);

            }
            static public int insertfuncionarios(string nome_completo, DateTime data_nascimento, string genero,
                string nacionalidade,
                string natalidade, string num_fiscal, string cartao_cidadao, string estado_civil, string seguranca_social,
                string telefone, string email,
                string cod_postal, string morada, DateTime data_emissao, DateTime data_validade, byte[] foto, string funcao)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
            new SqlParameter("@nome_completo", nome_completo),
              new SqlParameter("@data_nascimento", data_nascimento),
                new SqlParameter("@genero", genero),
                   new SqlParameter("@nacionalidade", nacionalidade),
                   new SqlParameter("@natalidade", natalidade),

                      new SqlParameter("@cod_postal", num_fiscal),
                         new SqlParameter("@morada", cartao_cidadao),

                            new SqlParameter("@nif", morada),
                                    new SqlParameter("@cc_bi", cod_postal),

                               new SqlParameter("@estado_civil", telefone),
                                  new SqlParameter("@segur_social", email),
                                       new SqlParameter("@telefone", estado_civil),
                                                     new SqlParameter("@email", seguranca_social),

                        new SqlParameter("@data_emissao", data_emissao),
                                       new SqlParameter("@data_validade", data_validade),

                                                   new SqlParameter("@foto", foto),
                                                                      new SqlParameter("@cargo", funcao),


           };

                return dal.executarNonQuery("INSERT into empregados (nome_completo,data_nascimento,genero,cargo,nacionalidade,natalidade, cod_postal,morada,nif,cc_bi,estado_civil,segur_social,telefone,email,data_emissao,data_vadalidade,foto,cargo)VALUES(@nome_completo,@data_nascimento,@genero,@cargo,@nacionalidade,@natalidade,@cod_postal,@morada,@nif,@cc_bi,@estado_civil,@segur_social,@telefone,@email,@data_emissao,@data_vadalidade,@foto,@cargo)", sqlParams);

            }

            static public int updatefuncionario(string nome_completo, DateTime data_nascimento, string genero, string nacionalidade,
                string natalidade, string num_fiscal, string cartao_cidadao, string morada, string cod_postal,
                string telefone, string email,
                string estado_civil, string seguranca_social, DateTime data_emissao, DateTime data_validade, byte[] foto, string cargo)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
            new SqlParameter("@nome_completo", nome_completo),
              new SqlParameter("@data_nascimento", data_nascimento),
                new SqlParameter("@genero", genero),
                   new SqlParameter("@nacionalidade", nacionalidade),
                   new SqlParameter("@natalidade", natalidade),

                      new SqlParameter("@cod_postal", num_fiscal),
                         new SqlParameter("@morada", cartao_cidadao),

                            new SqlParameter("@nif", morada),
                                    new SqlParameter("@cc_bi", cod_postal),

                               new SqlParameter("@estado_civil", telefone),
                                  new SqlParameter("@segur_social", email),
                                       new SqlParameter("@telefone", estado_civil),
                                                     new SqlParameter("@email", seguranca_social),

                        new SqlParameter("@data_emissao", data_emissao),
                                       new SqlParameter("@data_validae", data_validade),

                                                   new SqlParameter("@foto", foto),
                                                                      new SqlParameter("@cargo", cargo),
            };
                return dal.executarNonQuery("update [empregados] set [nome_completo]=@nome_completo,[data_nascimento]=@data_nascimento,[genero]=@genero,[cargo]=@cargo,[naciondalide]=@naciondalide,[natalidade]=@natalidade,[cod_postal]=@cod_postal,[morada]=@morada,[nif]=@nif,[cc_bi]=@cc_bi,[estado_civil]=@estado_civil,[segur_social]=@segur_social,[telefone]=@telefone,[email]=@email,[data_emissao]=@data_emissao,[data_vadalidade]=@data_vadalidade,[foto]=@foto,[cargo]=@cargo) where [id_funcionario]=@id_funcionario", sqlParams);
            }
            static public int deletefuncionario(string id)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id_empregado", id),

            };
                return dal.executarNonQuery("Delete From empregados WHERE[id_empregado]=@id_empregado", sqlParams);
            }

            static public object loadpic()
            {
                DAL dal = new DAL();
                return dal.executarScalar("select foto from empregados where id_funcionario=1", null);

            }

            static public int insertImagem(byte[] img)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@foto", img),

           };

                return dal.executarNonQuery("INSERT into empregados (foto) VALUES(@foto)", sqlParams);
            }

            static public object maxid(string id)
            {
                DAL dal = new DAL();

                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id", id),

           };
                return dal.executarScalar("select MAX(id_empregado) From empregados", sqlParams);

            }
        }
        public class medicos
        {

            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from medico", null);
            }

            static public int insertmedicos(int id_empregado, byte[] certificado, string especialidade, string salario,
                DateTime validade_contrato, string num_sala)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
   new SqlParameter("@id_empregado", id_empregado),
                new SqlParameter("@certificado", certificado),
                new SqlParameter("@especialidade", especialidade),
                new SqlParameter("@salario", salario),
                                                                new SqlParameter("@data_validade_contrato", validade_contrato),
                                                                 new SqlParameter("@num_sala", num_sala),

           };

                return dal.executarNonQuery("INSERT into medico (id_empregado,certificado,especialidade, salario,data_emissao_contrato,data_validade_contrato,num_sala) VALUES(@id_empregado,@certificado,@especialidade,@salario,@data_emissao_contrato,@data_validade_contrato,@num_sala)", sqlParams);
            }
            static public int updatemedicos(byte[] certificado, string especialidade, string salario,
                DateTime validade_contrato, string num_sala)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@certificado", certificado),
                new SqlParameter("@especialidade", especialidade),
                new SqlParameter("@salario", salario),
                                                                new SqlParameter("@data_validade_contrato", validade_contrato),
                                                                 new SqlParameter("@num_sala", num_sala),
            };
                return dal.executarNonQuery("update [medicos] set [id_empregado]=@id_empregado,[id_empregado]=@certificado,[especialidade]=@especialidade,[salario]=@salario,[data_emissao_contrato]=@data_emissao_contrato,[data_validade_contrato]=@data_validade_contrato,[num_sala]=@num_sala where [id_medicos]=@id_medicos", sqlParams);
            }
            static public int deletemedicos(string id_medicos)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id_medico", id_medicos),

            };
                return dal.executarNonQuery("Delete From medico WHERE[id_medico]=@id_medico", sqlParams);
            }

        }
        public class Laboratistas
        {

            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from laboratorista", null);
            }

            static public int inserlaboratistas(int id_empregado, byte[] certificado, string especialidade, string salario,
                DateTime validade_contrato, string num_sala)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
   new SqlParameter("@id_empregado", id_empregado),
                new SqlParameter("@certificado", certificado),
                new SqlParameter("@especialidade", especialidade),
                new SqlParameter("@salario", salario),
                                                                new SqlParameter("@data_validade_contrato", validade_contrato),
           };

                return dal.executarNonQuery("INSERT into laboratorista (id_empregado,certificado,especialidade, salario,data_emissao_contrato,data_validade_contrato,num_lab) VALUES(@id_empregado,@certificado,@especialidade,@salario,@data_emissao_contrato,@data_validade_contrato,@num_lab)", sqlParams);
            }
            static public int updatelaboratistas(byte[] certificado, string especialidade, string salario,
                DateTime validade_contrato, string num_sala)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@certificado", certificado),
                new SqlParameter("@especialidade", especialidade),
                new SqlParameter("@salario", salario),
                                                                new SqlParameter("@data_validade_contrato", validade_contrato),
            };
                return dal.executarNonQuery("update [laboratorista] set [id_empregado]=@id_empregado,[id_empregado]=@certificado,[especialidade]=@especialidade,[salario]=@salario,[data_emissao_contrato]=@data_emissao_contrato,[data_validade_contrato]=@data_validade_contrato,[num_lab]=@num_lab where [id_laboratista]=@id_laboratista", sqlParams);
            }
            static public int deletelaboratistas(string id_laboratista)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id_laborista", id_laboratista),

            };
                return dal.executarNonQuery("Delete From laboratorista WHERE[id_laboratista]=@id_laboratista", sqlParams);
            }

        }
        public class enfermeiros
        {

            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from enfermeiro", null);
            }

            static public int insertenfermeiros(int id_empregado, byte[] certificado, string especialidade, string salario,
                DateTime validade_contrato)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id_empregado", id_empregado),
                new SqlParameter("@certificado", certificado),
                new SqlParameter("@especialidade", especialidade),
                new SqlParameter("@salario", salario),
                                                                new SqlParameter("@data_validade_contrato", validade_contrato),
           };

                return dal.executarNonQuery("INSERT into enfermeiro (id_empregado,certificado,especialidade, salario,data_emissao_contrato,data_validade_contrato) VALUES(@id_empregado,@certificado,@especialidade,@salario,@data_emissao_contrato,@data_validade_contrato)", sqlParams);
            }
            static public int updateenfermeiro(byte[] certificado, string especialidade, string salario,
                DateTime validade_contrato)

            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@certificado", certificado),
                new SqlParameter("@especialidade", especialidade),
                new SqlParameter("@salario", salario),
                new SqlParameter("@data_validade_contrato", validade_contrato),
            };
                return dal.executarNonQuery("update [enfermeiro] set [id_empregado]=@id_empregado,[id_empregado]=@certificado,[especialidade]=@especialidade,[salario]=@salario,[data_emissao_contrato]=@data_emissao_contrato,[data_validade_contrato]=@data_validade_contrato where [id_enfermeiro]=@id_enfermeiro", sqlParams);
            }
            static public int deleteenfermeiro(string id_enfermeiro)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id_enfermeiro", id_enfermeiro),

            };
                return dal.executarNonQuery("Delete From enfermeiro WHERE[id_enfermeiro]=@id_enfermeiro", sqlParams);
            }
        }
        public class recepcionistas
        {

            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from recepcionista", null);
            }

            static public int insertrecepcionista(int id_empregado, byte[] certificado, string especialidade, string salario,
                DateTime validade_contrato, string num_lab)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
   new SqlParameter("@id_empregado", id_empregado),
                new SqlParameter("@certificado", certificado),
                new SqlParameter("@especialidade", especialidade),
                new SqlParameter("@salario", salario),
                                                                new SqlParameter("@data_validade_contrato", validade_contrato),
                                                                                        new SqlParameter("@num_lab", num_lab),
           };

                return dal.executarNonQuery("INSERT into recepcionista (id_empregado,certificado,especialidade, salario,data_emissao_contrato,data_validade_contrato,num_sala) VALUES(@id_empregado,@certificado,@especialidade,@salario,@data_emissao_contrato,@data_validade_contrato)", sqlParams);
            }
            static public int updaterecepcionista(byte[] certificado, string especialidade, string salario,
                DateTime validade_contrato, string num_lab)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@certificado", certificado),
                new SqlParameter("@especialidade", especialidade),
                new SqlParameter("@salario", salario),
                                                                new SqlParameter("@data_validade_contrato", validade_contrato),
                                                                                        new SqlParameter("@num_lab", num_lab),
            };
                return dal.executarNonQuery("update [recepcionista] set [id_empregado]=@id_empregado,[id_empregado]=@certificado,[especialidade]=@especialidade,[salario]=@salario,[data_emissao_contrato]=@data_emissao_contrato,[data_validade_contrato]=@data_validade_contrato,[num_sala]=@num_sala where [id_medicos]=@id_medicos", sqlParams);
            }
            static public int deleterecepcionista(string id)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id_enfermeiro", id),

            };
                return dal.executarNonQuery("Delete From recepcionista WHERE[id_recepcionista]=@id_recepcionista", sqlParams);
            }


        }
        public class Utentes
        {

            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from pacientes", null);
            }

            static public int insertpacientes(string nome_completo, string data_nascimento, string genero, string nacionalidade, string natalidade, string medico, string num_fiscal, string cartaoc, string segurancasocial, string estadocivil, string cod_postal, string conselho, string morada, string telefone, string email, string sangueo, string taxa, DateTime emissao, DateTime validade, byte[] foto)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
            new SqlParameter("@nome_completo", nome_completo),
              new SqlParameter("@data_nascimento", data_nascimento),
                new SqlParameter("@genero", genero),
                  new SqlParameter("@nacionalidade", nacionalidade),
                    new SqlParameter("@natalidade", natalidade),
                      new SqlParameter("@medico_familia", medico),

                      new SqlParameter("@num_fisca", num_fiscal),
                         new SqlParameter("@cartao_cidadao", cartaoc),
                                 new SqlParameter("@seguranca_social", segurancasocial),
                            new SqlParameter("@estado_civil", estadocivil),

                        new SqlParameter("@codigo_postal", cod_postal),
                                           new SqlParameter("@conselho", conselho),
                            new SqlParameter("@morada", morada),
                               new SqlParameter("@telefone", telefone),
                                  new SqlParameter("@email", email),

                                          new SqlParameter("@grupo_sanquineo", sangueo),
                          new SqlParameter("@num_beneficitario", taxa),

                                                   new SqlParameter("@foto", foto),

                    new SqlParameter("@data_registo", emissao),
                    new SqlParameter("@validade", validade),



           };

                return dal.executarNonQuery("INSERT into pacientes (nome_completo,data_nascimento,genero,nacionalidade, natalidade, medico_familia,num_fiscal,cartao_cidadao,morada,telefone,email,estado_civil,grupo_sanquineo,seguranca_social,num_beneficitario,data_registo,doto,validade) VALUES(@nome_completo, @data_nascimento, @genero,@nacionalidade,@natalidade, @medico_familia,@num_fiscal, @cartao_cidadao, @morada, @telefone, @email, @estado_civil, @grupo_sanquineo, @seguranca_social, @num_beneficitario, @data_registo, @id_medico @cod_alerta, @foto, @validade)", sqlParams);
            }

            static public int updatepaciente(string nome_completo, string data_nascimento, string genero, string nacionalidade, string natalidade, string medico, string num_fiscal, string cartaoc, string segurancasocial, string estadocivil, string cod_postal, string conselho, string morada, string telefone, string email, string sangueo, string taxa, DateTime emissao, DateTime validade, byte[] foto)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                  new SqlParameter("@nome_completo", nome_completo),
              new SqlParameter("@data_nascimento", data_nascimento),
                new SqlParameter("@genero", genero),
                  new SqlParameter("@nacionalidade", nacionalidade),
                    new SqlParameter("@natalidade", natalidade),
                      new SqlParameter("@medico_familia", medico),

                      new SqlParameter("@num_fisca", num_fiscal),
                         new SqlParameter("@cartao_cidadao", cartaoc),
                                 new SqlParameter("@seguranca_social", segurancasocial),
                            new SqlParameter("@estado_civil", estadocivil),

                        new SqlParameter("@codigo_postal", cod_postal),
                                           new SqlParameter("@conselho", conselho),
                            new SqlParameter("@morada", morada),
                               new SqlParameter("@telefone", telefone),
                                  new SqlParameter("@email", email),

                                          new SqlParameter("@grupo_sanquineo", sangueo),
                          new SqlParameter("@num_beneficitario", taxa),

                                                   new SqlParameter("@foto", foto),

                    new SqlParameter("@data_registo", emissao),
                    new SqlParameter("@validade", validade),


            };
                return dal.executarNonQuery("update [pacientes] set [nome_completo]=@nome_completo, [data_nascimento]=@data_nascimento, [nacionalidade]=@nacionalidade,[natalidade]=@natalidade,  [medico_familia]=@medico_familia, [num_fiscal]=@num_fiscal, [cartao_cidadao]=@cartao_cidadao, [morada]=@morada, [telefone]=@telefone, [email]=@email, [estado_civil]=@estado_civil, [grupo_sanquineo]=@grupo_sanquineo, [seguranca_social]=@seguranca_social, [num_beneficitario]=@num_beneficitario, [data_registo]=@data_registo, [cod_alerta]=@cod_alerta, [foto]=@foto, [validade]=@validade where [id_paciente]=@id_paciente", sqlParams);
            }
            static public int deletepaciente(string id)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id_paciente", id),

            };
                return dal.executarNonQuery("Delete From pacientes WHERE[id_paciente]=@id_paciente", sqlParams);
            }
            static public object loadpic()
            {
                DAL dal = new DAL();
                return dal.executarScalar("select foto from pacientes where id_paciente=1", null);

            }


            static public int insertImagem(byte[] img)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@foto", img),

           };

                return dal.executarNonQuery("INSERT into pacientes (foto) VALUES(@foto)", sqlParams);
            }
        }
        public class consultas
        {

            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from consultas", null);
            }

            static public int insertconsulta(string funcionario, string id_utente, string data_consulta, int hora, string nome_utente, string nome_medico, string categoria, string taxa_moderadora, string prioridade, string obervacoes, DateTime emissao, string horaregisto)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id_utente", id_utente),
                new SqlParameter("@data_consulta", data_consulta),

                     new SqlParameter("@hora", hora),
                          new SqlParameter("@nome_utente", nome_utente),
                               new SqlParameter("@nome_medico", nome_medico),
                                    new SqlParameter("@categoria", categoria),
                                         new SqlParameter("@taxa_moderadora", taxa_moderadora),
                                             new SqlParameter("@priopridade", prioridade),
                                     new SqlParameter("@obervacoes", obervacoes),
                                         new SqlParameter("@emissao", emissao),
                                     new SqlParameter("@hora_registo", horaregisto),
           };

                return dal.executarNonQuery("INSERT into consultas (id_utente,data_consulta,hora,nome_medico,categoria,taxa_moderadora,priopridade,obervacoes) VALUES(@id_utente,@data_consulta,@hora,@nome_medico,@categoria,@taxa_moderadora,@priopridade,@obervacoes)", sqlParams);
            }
            static public int updateconsulta(string funcionario, string id_utente, string data_consulta, int hora, string nome_utente, string nome_medico, string categoria, string taxa_moderadora, string prioridade, string obervacoes, DateTime emissao, string horaregisto)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id_utente", id_utente),
                new SqlParameter("@data_consulta", data_consulta),

                     new SqlParameter("@hora", hora),
                          new SqlParameter("@nome_utente", nome_utente),
                               new SqlParameter("@nome_medico", nome_medico),
                                    new SqlParameter("@categoria", categoria),
                                         new SqlParameter("@taxa_moderadora", taxa_moderadora),
                                             new SqlParameter("@priopridade", prioridade),
                                     new SqlParameter("@obervacoes", obervacoes),
                                         new SqlParameter("@emissao", emissao),
                                     new SqlParameter("@hora_registo", horaregisto),
            };
                return dal.executarNonQuery("update [consultas] set [id_utente]=@id_utente,[data_consulta]=@data_consulta,[hora]=@hora,[nome_medico]=@nome_medico,[categoria]=@categoria,[taxa_moderadora]=@taxa_moderadora,[priopridade]=@priopridade,[obervacoes]=@obervacoes) where [id_consulta]=@id_consulta", sqlParams);
            }
            static public int deleteconsulta(string id_consulta)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id_consulta", id_consulta),

            };
                return dal.executarNonQuery("Delete From consultas WHERE[id_consulta]=@id_consulta", sqlParams);
            }
        }
        public class receitas
        {

            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from receitas", null);
            }

            static public int insertreceitas(string ref_medicamento, string ref_utente, string ref_medico, string nome_utente,
                string nome_medico, string categoria, string ref_taxa, string ref_receita, string obervacoes,
                DateTime emissao, DateTime validade)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                                    new SqlParameter("@ref_medicamento", ref_medicamento),
                new SqlParameter("@ref_utente", ref_utente),
                new SqlParameter("@ref_medico", ref_medico),
                new SqlParameter("@nome_utente", nome_utente),
                     new SqlParameter("@nome_medico", nome_medico),
                          new SqlParameter("@categoria", categoria),
                               new SqlParameter("@ref_taxa", ref_taxa),
                                    new SqlParameter("@receita", ref_receita),
                                         new SqlParameter("@obervacoes", obervacoes),
                                                              new SqlParameter("@emissao", emissao),
                                         new SqlParameter("@validade", validade),
           };

                return dal.executarNonQuery("INSERT into receitas (ref_medicamento,ref_utente,ref_medico,nome_utente,nome_medico,categoria,ref_taxa, receita, obervacoes, emissao,validade) VALUES(@ref_medicamento,@ref_utente,@ref_medico,@nome_utente,@nome_medico,@categoria,@ref_taxa,@receita,@obervacoes,@emissao,@validade)", sqlParams);
            }
            static public int updatereceitas(string ref_medicamento, string ref_utente, string ref_medico, string nome_utente,
                string nome_medico, string categoria, string ref_taxa, string ref_receita, string obervacoes,
                DateTime emissao, DateTime validade)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                                    new SqlParameter("@ref_medicamento", ref_medicamento),
                new SqlParameter("@ref_utente", ref_utente),
                new SqlParameter("@ref_medico", ref_medico),
                new SqlParameter("@nome_utente", nome_utente),
                     new SqlParameter("@nome_medico", nome_medico),
                          new SqlParameter("@categoria", categoria),
                               new SqlParameter("@ref_taxa", ref_taxa),
                                    new SqlParameter("@receita", ref_receita),
                                         new SqlParameter("@obervacoes", obervacoes),
                                                              new SqlParameter("@emissao", emissao),
                                         new SqlParameter("@validade", validade),
            };
                return dal.executarNonQuery("update [receitas] set [ref_medicamento]=@ref_medicamento,[ref_utente]=@ref_utente,[ref_medico]=@ref_medico,[nome_utente]=@nome_utente,[nome_medico]=@nome_medico,[categoria]=@categoria,[ref_taxa]=@ref_taxa, [receita]=@receita, [obervacoes]=@obervacoes, [emissao]=@emissao,[validade]=@validade where [id_receita]=@id_receita", sqlParams);
            }
            static public int deletereceitas(string id_receita)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id_receita", id_receita),

            };
                return dal.executarNonQuery("Delete From receitas WHERE[id_receita]=@id_receita", sqlParams);
            }
        }
        public class exames
        {

            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from exames", null);
            }

            static public int insertexames(string id_paciente, DateTime data_exame, string hora_exame, string nome_utente, string nome_medico, string categoria,
                 string prioridade, string taxa_moderadora, string receita, string oberv, DateTime emissao, DateTime validade)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id_paciente", id_paciente),
                new SqlParameter("@data_exame", data_exame),
                new SqlParameter("@hora_exame", hora_exame),
                new SqlParameter("@nome_utente", nome_utente),
                new SqlParameter("@nome_medico", nome_medico),
                new SqlParameter("categoria", categoria),
                                new SqlParameter("prioridade", prioridade),
                                                new SqlParameter("taxa_moderadora", taxa_moderadora),
                                                                new SqlParameter("receita", receita),
                                                                new SqlParameter("oberv", oberv),
                                                                new SqlParameter("emissao", emissao),
                                                                new SqlParameter("validade", validade)

           };

                return dal.executarNonQuery("INSERT into exames (id_paciente,data_exame,hora_exame,nome_utente,nome_medico,categoria,priopridade,taxa_moderadora,receita,oberv,emissao,validade) VALUES(@id_paciente,@data_exame,@hora_exame,@nome_utente,@nome_medico,@categoria,@priopridade,@taxa_moderadora,@receita,@oberv,@emissao,@validade)", sqlParams);
            }
            static public int updateexame(string id_paciente, DateTime data_exame, string hora_exame, string nome_utente, string nome_medico, string categoria,
                 string prioridade, string taxa_moderadora, string receita, string oberv, DateTime emissao, DateTime validade)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id_paciente", id_paciente),
                new SqlParameter("@data_exame", data_exame),
                new SqlParameter("@hora_exame", hora_exame),
                new SqlParameter("@nome_utente", nome_utente),
                new SqlParameter("@nome_medico", nome_medico),
                new SqlParameter("categoria", categoria),
                                new SqlParameter("prioridade", prioridade),
                                                new SqlParameter("taxa_moderadora", taxa_moderadora),
                                                                new SqlParameter("receita", receita),
                                                                new SqlParameter("oberv", oberv),
                                                                new SqlParameter("emissao", emissao),
                                                                new SqlParameter("validade", validade)
            };
                return dal.executarNonQuery("update [exames] set [id_paciente]=@id_paciente,[data_exame]=@data_exame,[hora_exame]=@hora_exame,[nome_utente]=@nome_utente,[nome_medico]=@nome_medico,[categoria]=@categoria,[priopridade]=@priopridade,[taxa_moderadora]=@taxa_moderadora,[receita]=@receita,[oberv]=@oberv,[emissao]=@emissao,[validade]=@validade where [id_exame]=@id_exame", sqlParams);
            }
            static public int deleteexame(string id_exame)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id_exame", id_exame),

            };
                return dal.executarNonQuery("Delete From exames WHERE[id_exame]=@id_exame", sqlParams);
            }
        }
        public class analises
        {

            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from analises", null);
            }

            static public int insertanalises(string id_utente, string nome_medico, string obervacoes, string taxa_moderadora,

                string categoria, string prioridade, DateTime data_consulta, string hora_consulta, DateTime emissao, string hora_emissao)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id_utente", id_utente),
                new SqlParameter("@nome_medico", nome_medico),
                new SqlParameter("@obervacoes", obervacoes),
                new SqlParameter("@taxa_moderadora", taxa_moderadora),
                new SqlParameter("@categoria", categoria),
                new SqlParameter("prioridade", prioridade),
                                new SqlParameter("data_consulta", data_consulta),
                                                new SqlParameter("hora_consulta", hora_consulta),
                                                                new SqlParameter("emissao", emissao),
                                                                new SqlParameter("hora_emissao", hora_emissao),


           };

                return dal.executarNonQuery("INSERT into analises (id_utente,nome_medico,obervacoes,taxa_moderadora,categoria,prioridade,data_consulta,hora_consulta,emissao,hora_emissao) VALUES(@id_utente,@nome_medico,@obervacoes,@taxa_moderadora,@categoria,@prioridade,@data_consulta,@hora_consulta,@emissao,@hora_emissao)", sqlParams);
            }
            static public int updateanalises(string id_paciente, DateTime data_exame, string hora_exame, string nome_utente, string nome_medico, string categoria,
                 string prioridade, string taxa_moderadora, string receita, string oberv, DateTime emissao, DateTime validade)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id_paciente", id_paciente),
                new SqlParameter("@data_exame", data_exame),
                new SqlParameter("@hora_exame", hora_exame),
                new SqlParameter("@nome_utente", nome_utente),
                new SqlParameter("@nome_medico", nome_medico),
                new SqlParameter("categoria", categoria),
                                new SqlParameter("prioridade", prioridade),
                                                new SqlParameter("taxa_moderadora", taxa_moderadora),
                                                                new SqlParameter("receita", receita),
                                                                new SqlParameter("oberv", oberv),
                                                                new SqlParameter("emissao", emissao),
                                                                new SqlParameter("validade", validade)
            };
                return dal.executarNonQuery("update [analises] set [id_paciente]=@id_paciente,[data_exame]=@data_exame,[hora_exame]=@hora_exame,[nome_utente]=@nome_utente,[nome_medico]=@nome_medico,[categoria]=@categoria,[priopridade]=@priopridade,[taxa_moderadora]=@taxa_moderadora,[receita]=@receita,[oberv]=@oberv,[emissao]=@emissao,[validade]=@validade where [id_exame]=@id_exame", sqlParams);
            }
            static public int deleteanalises(string id_analises)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id_analises", id_analises),

            };
                return dal.executarNonQuery("Delete From analises WHERE[id_analises]=@id_analises", sqlParams);
            }
        }

        public class cirugia
        {

            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from cirugia", null);
            }

            static public int insert_cirugia(string ref_utente, DateTime data_cirugia, string nome, string medico, string cirugico, string categoria,
                string prioridade, string grupo_sanguineo, string taxa_moderadora, DateTime emissao, string hora)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
            new SqlParameter("@ref_utente", ref_utente),
                    new SqlParameter("@data_cirugia", data_cirugia),
                        new SqlParameter("@nome", nome),
                            new SqlParameter("@medico", medico),
                                new SqlParameter("@cirugico", cirugico),
                                    new SqlParameter("@categoria", categoria),
                                                   new SqlParameter("@prioridade", prioridade),
                        new SqlParameter("@grupo_sanguineo", grupo_sanguineo),
                            new SqlParameter("@taxa_moderadora", taxa_moderadora),
                                    new SqlParameter("@emissao", emissao),
                                         new SqlParameter("@hora", hora),
           };

                return dal.executarNonQuery("INSERT into cirugia (ref_utente,data_cirugia,nome,medico,cirugico,categoria,prioridade,grupo_sanguineo,taxa_moderadora,emissao,hora) VALUES(@ref_utente,@data_cirugia,@nome,@medico,@cirugico,@categoria,@prioridade,@grupo_sanguineo,@taxa_moderadora,@emissao,@hora)", sqlParams);
            }
            static public int update_cirugia(string ref_utente, DateTime data_cirugia, string nome, string medico, string cirugico, string categoria,
                string prioridade, string grupo_sanguineo, string taxa_moderadora, DateTime emissao, string hora)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
            new SqlParameter("@ref_utente", ref_utente),
                    new SqlParameter("@data_cirugia", data_cirugia),
                        new SqlParameter("@nome", nome),
                            new SqlParameter("@medico", medico),
                                new SqlParameter("@cirugico", cirugico),
                                    new SqlParameter("@categoria", categoria),
                                                   new SqlParameter("@prioridade", prioridade),
                        new SqlParameter("@grupo_sanguineo", grupo_sanguineo),
                            new SqlParameter("@taxa_moderadora", taxa_moderadora),
                                    new SqlParameter("@emissao", emissao),
                                         new SqlParameter("@hora", hora),
            };
                return dal.executarNonQuery("update [cirugia] set [ref_utente]=@ref_utente,[data_cirugia]=@data_cirugia,[nome]=@nome,[medico]=@medico,[cirugico]=@cirugico,[categoria]=@categoria,[prioridade]=@prioridade,[grupo_sanguineo]=@grupo_sanguineo,[taxa_moderadora]=@taxa_moderadora,[emissao]=@emissao,[hora]=@hora where [id_cirugia]=@id_cirugia", sqlParams);
            }
            static public int delete_cirugia(string id_admcirugia)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@Id_cirugia", id_admcirugia),

            };
                return dal.executarNonQuery("Delete From cirugia WHERE[Id_cirugia]=@Id_cirugia", sqlParams);
            }
        }
        public class mediamentos
        {

            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from medicamentos", null);
            }

            static public int insertmedi(string nome, string referencia, string quantidade, string preco, string categoria, string fabricante, string efeitos, string especificacoes, string receita, DateTime data_emissao, DateTime data_validade)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@nome", nome),
                new SqlParameter("@referencia", referencia),
                new SqlParameter("@quantidade", quantidade),
                         new SqlParameter("@preco", preco),
                new SqlParameter("@categoria", categoria),
                new SqlParameter("@fabricante", fabricante),
                         new SqlParameter("@efeitos_secundarios", efeitos),
                new SqlParameter("@especificacoes", especificacoes),
                new SqlParameter("@receita_medica", receita),
                  new SqlParameter("@data_emissao", data_emissao),
                    new SqlParameter("@data_validade", data_validade),
           };

                return dal.executarNonQuery("INSERT into medicamentos (Nome,referencia, quantidade, preco, categoria,fabricante,efeitos_secundarios,especificacoes,receita_medica,data_emissao,data_validade) VALUES(@Nome,@referencia, @quantidade, @preco, @categoria,@fabricante,@efeitos_secundarios,@especificacoes,@receita_medica,@data_emissao,@data_validade)", sqlParams);
            }
            static public int updatemedi(string nome, string referencia, string quantidade, string preco, string categoria, string fabricante, string efeitos, string especificacoes, string receita, DateTime data_emissao, DateTime data_validade)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@nome", nome),
                new SqlParameter("@referencia", referencia),
                new SqlParameter("@quantidade", quantidade),
                         new SqlParameter("@preco", preco),
                new SqlParameter("@categoria", categoria),
                new SqlParameter("@fabricante", fabricante),
                         new SqlParameter("@efeitos_secundarios", efeitos),
                new SqlParameter("@especificacoes", especificacoes),
                new SqlParameter("@receita_medica", receita),
                  new SqlParameter("@data_emissao", data_emissao),
                    new SqlParameter("@data_validade", data_validade),
            };
                return dal.executarNonQuery("update [medicamentos] set [nome]=@Nome,[referencia]=@referencia, [quantidade]=@quantidade, [preco]=@preco, [categoria]=@categoria,[fabricante]=@fabricante,[efeitos_secundarios]=@efeitos_secundarios,[especificacoes]=@especificacoes,[receita]=@receita_medica,[data_emissao]=@data_emissao,[data_validade]=@data_validade where [id_medicamento]=@id_medicamento", sqlParams);
            }
            static public int deletemedi(string id_medicamento)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id_medicamento", id_medicamento),

            };
                return dal.executarNonQuery("Delete From medicamentos WHERE[id_medicamento]=@id_medicamento", sqlParams);
            }
        }
        public class tratamentos
        {

            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from tratamentos", null);
            }

            static public int inserttatamento(string id_utente, string nome_enf, DateTime data_trat, string hora_trat, string prioridade,
                string nome_utente, string doenças, string categoria, string num_horas, string obervs, DateTime data_emissao, string hora)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id_utente", id_utente),
                new SqlParameter("@nome_enf", nome_enf),
                new SqlParameter("@data_trat", data_trat),
                         new SqlParameter("@hora_trat", hora_trat),
                new SqlParameter("@prioridade", prioridade),
                new SqlParameter("@nome_utente", nome_utente),
                         new SqlParameter("@doenças", doenças),
                new SqlParameter("@categoria", categoria),
                new SqlParameter("@num_horas", num_horas),
                  new SqlParameter("@obervs", obervs),
                    new SqlParameter("@data_emissao", data_emissao),
                      new SqlParameter("@hora", hora),
           };

                return dal.executarNonQuery("INSERT into tratamentos (id_utente,nome_enf, data_trat, hora_trat, prioridade, nome_utente, doenças, categoria, num_horas, obervs, data_emissao, hora) VALUES(@id_utente,@nome_enf,@data_trat, @hora_trat, @prioridade, @nome_utente, @doenças, @categoria, @num_horas, @obervs, @data_emissao, @hora)", sqlParams);
            }
            static public int updatetratamento(string id_utente, string nome_enf, DateTime data_trat, string hora_trat, string prioridade,
                string nome_utente, string doenças, string categoria, string num_horas, string obervs, DateTime data_emissao, string hora)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id_utente", id_utente),
                new SqlParameter("@nome_enf", nome_enf),
                new SqlParameter("@data_trat", data_trat),
                         new SqlParameter("@hora_trat", hora_trat),
                new SqlParameter("@prioridade", prioridade),
                new SqlParameter("@nome_utente", nome_utente),
                         new SqlParameter("@doenças", doenças),
                new SqlParameter("@categoria", categoria),
                new SqlParameter("@num_horas", num_horas),
                  new SqlParameter("@obervs", obervs),
                    new SqlParameter("@data_emissao", data_emissao),
                      new SqlParameter("@hora", hora),
            };
                return dal.executarNonQuery("update [tratamentos] set [id_utente]=@id_utente,[nome_enf]=@nome_enf,[data_trat]=@data_trat, [hora_trat]=@hora_trat, [prioridade]=@prioridade,[nome_utente]=@nome_utente,[doenças]=@doenças, [categoria]=@categoria, [num_horas]=@num_horas, [obervs]=@obervs, [data_emissao]=@data_emissao,[hora]=@hora where [id_tratamento]=@id_tratamento", sqlParams);
            }
            static public int deletetatamento(string id_medicamento)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id_tratamento", id_medicamento),

            };
                return dal.executarNonQuery("Delete From tratamentos WHERE[id_tratamento]=@id_tratamento", sqlParams);
            }
        }
        public class salarios
        {

            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from salarios", null);
            }

            static public int insersalarios(string id_empregado, string nome_empregado, string sal_liquido, string sal_bruto, string descontos, string num_horas,
                string horas_extra, string ref_salarial, string num_fiscal, string met_pagamento, string mes, DateTime emissao)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id_empregado", id_empregado),
                new SqlParameter("@nome_empregado", nome_empregado),

                     new SqlParameter("@sal_liquido", sal_liquido),
                          new SqlParameter("@sal_bruto", sal_bruto),
                               new SqlParameter("@descontos", descontos),
                                    new SqlParameter("@num_horas", num_horas),
                                         new SqlParameter("@horas_extra", horas_extra),
                                             new SqlParameter("@ref_salarial", ref_salarial),
                                     new SqlParameter("@num_fiscal", num_fiscal),
                                                             new SqlParameter("@met_pagamento", met_pagamento),
                                                                                     new SqlParameter("@mes", mes),
                                                                                                             new SqlParameter("@emissao", emissao),

           };

                return dal.executarNonQuery("INSERT into salario (id_empregado,nome_completo,sal_liquido,sal_bruto,descontos,num_horas,horas_extra,ref_salarial,met_pagamento,mes,essiao) VALUES(@id_empregado,@nome_completo,@sal_liquido,@sal_bruto,@descontos,@num_horas,@horas_extra,@ref_salarial,@met_pagamento,@mes,@emissao)", sqlParams);
            }
            static public int updatesalarios(string id_empregado, string nome_empregado, string sal_liquido, string sal_bruto, string descontos, string num_horas,
                string horas_extra, string ref_salarial, string num_fiscal, string met_pagamento, string mes, DateTime emissao)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
              new SqlParameter("@id_empregado", id_empregado),
                new SqlParameter("@nome_empregado", nome_empregado),

                     new SqlParameter("@sal_liquido", sal_liquido),
                          new SqlParameter("@sal_bruto", sal_bruto),
                               new SqlParameter("@descontos", descontos),
                                    new SqlParameter("@num_horas", num_horas),
                                         new SqlParameter("@horas_extra", horas_extra),
                                             new SqlParameter("@ref_salarial", ref_salarial),
                                     new SqlParameter("@num_fiscal", num_fiscal),
                                                             new SqlParameter("@met_pagamento", met_pagamento),
                                                                                     new SqlParameter("@mes", mes),
                                                                                                             new SqlParameter("@emissao", emissao),
            };
                return dal.executarNonQuery("update [salarios] set [id_empregado]=@id_empregado,[nome_completo]=@nome_completo,[sal_liquido]=@sal_liquido,[sal_bruto]=@sal_bruto,[descontos]=@descontos,[num_horas]=@num_horas,[horas_extra]=@horas_extra,[ref_salarial]=@ref_salarial,[met_pagamento]=@met_pagamento,[mes]=@mes,[emissaoo]=@emissao where [id_salario]=@id_salario ", sqlParams);

            }
            static public int deletesalarios(string id_salarios)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id_salario", id_salarios),

            };
                return dal.executarNonQuery("Delete From salarios WHERE[id_salario]=@id_salario", sqlParams);
            }
        }
        public class prefil
        {

            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from prefil", null);
            }

            static public int insertprefil(string cargo, string login, string password)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@cargo", cargo),
                new SqlParameter("@login", login),
                new SqlParameter("@password", password)
           };

                return dal.executarNonQuery("INSERT into prefil (cargo,login,password) VALUES(@cargo,@login,@password)", sqlParams);
            }

            static public int updateprefil(string password)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{

                new SqlParameter("@password", password)
            };
                return dal.executarNonQuery("update [prefil] set [password]=@password, where [id_prefil]=@id_prefil", sqlParams);
            }
            static public int deleteCliente(string id_prefil)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id_prefil", id_prefil),

            };
                return dal.executarNonQuery("Delete From prefil WHERE[id_prefil]=@id_prefil", sqlParams);
            }
            static public DataTable authlogin(string login, string password, string cargo)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlparams = new SqlParameter[]{
                    new SqlParameter("@login", login),
                    new SqlParameter("@password", password),
                       new SqlParameter("@cargo", cargo),
            };
                return dal.executarReader("select *  from prefil where [login]=@login and [password]=@password and [cargo]=@cargo", sqlparams);
            }
        }
        public class financiamento
        {

            static public DataTable Load()
            {
                DAL dal = new DAL();
                return dal.executarReader("select * from gestao_financeira", null);
            }

            static public int insertfinan(string nome_produto, string ref_pagamento, string valor, string quantidade,
                DateTime data_validade, string descricao, string iva, string id_referencial, string empresa, string contacto,
                string status, DateTime emissao)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                    new SqlParameter("@nome_produto", nome_produto),
                new SqlParameter("@ref_pagamento", ref_pagamento),
                new SqlParameter("@valor", valor),
                new SqlParameter("@quantidade", quantidade),
                new SqlParameter("@data_validade", data_validade),
                new SqlParameter("@descricao", descricao),
                new SqlParameter("@iva", iva),

                new SqlParameter("@id_referencial", id_referencial),
                new SqlParameter("@empresa", empresa),
                                new SqlParameter("@contacto", contacto),
                                                new SqlParameter("@status", status),
                                                            new SqlParameter("@contacto", contacto),
                                                             new SqlParameter("@emissao", emissao),
           };


                return dal.executarNonQuery("INSERT into gestao_financeira (nome_produto,valor, recibo, data_pagamento, data_emissao, data_validade, referencia, quantidade,empresa,representante,IVA,status,contacto) VALUES(@nome_produto,@valor,@recibo,@data_pagamento,@data_emissao,@data_validade,@referencia,@quantidade,@empresa,@representante,@IVA,@status,@contacto)", sqlParams);
            }
            static public int updatefinan(string nome_produto, string ref_pagamento, string valor, string quantidade,
                DateTime data_validade, string descricao, string iva, string id_referencial, string empresa, string contacto,
                string status, DateTime emissao)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                    new SqlParameter("@nome_produto", nome_produto),
                new SqlParameter("@ref_pagamento", ref_pagamento),
                new SqlParameter("@valor", valor),
                new SqlParameter("@quantidade", quantidade),
                new SqlParameter("@data_validade", data_validade),
                new SqlParameter("@descricao", descricao),
                new SqlParameter("@iva", iva),

                new SqlParameter("@id_referencial", id_referencial),
                new SqlParameter("@empresa", empresa),
                                new SqlParameter("@contacto", contacto),
                                                new SqlParameter("@status", status),
                                                            new SqlParameter("@contacto", contacto),
                                                             new SqlParameter("@emissao", emissao),
            };
                return dal.executarNonQuery("update [gestao_financeira] set [nome_produto]=@nome_produto, [valor]=@valor, [recibo]=@recibo, [data_pagamento]=@data_pagamento, [data_lancamento]=@data_lancamento, [data_validade]=@data_validade, [referencia]=@referencia,[quantidade]=@quantidade,[empresa]=@empresa,[representate]=@representate,[IVA]=@IVA,[status]=@status,[contacto]=@contacto where [id_financa]=@id_financa", sqlParams);
            }
            static public int deletefinan(string id_financa)
            {
                DAL dal = new DAL();
                SqlParameter[] sqlParams = new SqlParameter[]{
                new SqlParameter("@id_financa", id_financa),

            };
                return dal.executarNonQuery("Delete From gestao_financeira WHERE[id_financa]=@id_financa", sqlParams);
            }

        }

    }
}



