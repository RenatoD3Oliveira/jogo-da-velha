using jogo_da_velha.controller;
using jogo_da_velha.model;
using System.Data.SqlClient;
using System;

public class UsuarioDAO
{
    public bool VerificarUsuario(string nick, string senha)
    {
        using (SqlConnection con = Connection.ReturnConnect())
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Usuarios WHERE nick = @nick AND senha = @senha", con);
            cmd.Parameters.AddWithValue("@nick", nick);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao verificar usuário no banco.\n" + err.Message);
            }
            finally
            {
                Connection.CloseConnect();
            }
        }
    }

    public void AdicionarUsuario(Usuario usuario)
    {
        using (SqlConnection con = Connection.ReturnConnect())
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO Usuarios (nome, nick, senha, pontos) VALUES (@nome, @nick, @senha, @pontos)", con);
            cmd.Parameters.AddWithValue("@nome", usuario.Nome);
            cmd.Parameters.AddWithValue("@nick", usuario.Nick);
            cmd.Parameters.AddWithValue("@senha", usuario.Password);
            cmd.Parameters.AddWithValue("@pontos", usuario.Pontos);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir usuário.\n" + err.Message);
            }
            finally
            {
                Connection.CloseConnect();
            }
        }
    }

    public int ObterPontos(string nick)
    {
        using (SqlConnection con = Connection.ReturnConnect())
        {
            SqlCommand cmd = new SqlCommand("SELECT ISNULL(pontos, 0) FROM Usuarios WHERE nick = @nick", con);
            cmd.Parameters.AddWithValue("@nick", nick);

            try
            {
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao obter pontos do usuário.\n" + err.Message);
            }
            finally
            {
                Connection.CloseConnect();
            }
        }
    }

    public void AtualizarPontos(string nick, int pontos)
    {
        using (SqlConnection con = Connection.ReturnConnect())
        {
            SqlCommand cmd = new SqlCommand("UPDATE Usuarios SET pontos = @pontos WHERE nick = @nick", con);
            cmd.Parameters.AddWithValue("@nick", nick);
            cmd.Parameters.AddWithValue("@pontos", pontos);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao atualizar pontos do usuário.\n" + err.Message);
            }
            finally
            {
                Connection.CloseConnect();
            }
        }
    }

    public bool ExcluirUsuario(string nick, string senha)
    {
        using (SqlConnection con = Connection.ReturnConnect())
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Usuarios WHERE nick = @nick AND senha = @senha", con);
            cmd.Parameters.AddWithValue("@nick", nick);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0; // Retorna true se um usuário foi excluído
            }
            catch (Exception err)
            {
                throw new Exception("Erro ao excluir usuário: " + err.Message);
            }
            finally
            {
                Connection.CloseConnect(); // Certifique-se de fechar a conexão
            }
        }
    }
}
