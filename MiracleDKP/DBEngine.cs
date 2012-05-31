using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace MiracleDKP
{
    public class DBEngine
    {
        private MySqlConnection _conn;
        private string _admin, _password;
        public DBEngine(string ConnectionString)
        {
            _conn = new MySqlConnection(ConnectionString);
        }

        public bool InitAdminLogin(string _user, string _pass)
        {
            bool _return = true;
            try
            {
                _conn.Open();
                MySqlCommand _loginCmd =
                    new MySqlCommand("SELECT COUNT(*) FROM administrators WHERE user = @User AND password = @Pass LIMIT 1;", _conn);
                MySqlParameter _pUser = new MySqlParameter("@User", _user);
                MySqlParameter _pPass = new MySqlParameter("@Pass", _pass);
                _loginCmd.Parameters.Add(_pUser);
                _loginCmd.Parameters.Add(_pPass);
                int _ok = Int32.Parse(_loginCmd.ExecuteScalar().ToString());
                if (_ok < 1)
                    throw new Exception();
                else
                {
                    _admin = _user;
                    _password = _pass;
                }
            }
            catch (Exception)
            {
                _return = false;
            }
            finally
            {
                _conn.Close();
            }
            return _return;
        }


        internal bool AddNews(string _news)
        {
            bool _return = true;
            try
            {
                _conn.Open();
                MySqlCommand _newsAdd = new MySqlCommand("INSERT INTO infos (created_by, date, info) VALUES (@User, @Date, @Info)", _conn);
                MySqlParameter _pUser = new MySqlParameter("@User", _admin);
                MySqlParameter _pDate = new MySqlParameter("@Date", DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
                MySqlParameter _pInfo = new MySqlParameter("@Info", _news);
                _newsAdd.Parameters.Add(_pUser);
                _newsAdd.Parameters.Add(_pDate);
                _newsAdd.Parameters.Add(_pInfo);
                if (_newsAdd.ExecuteNonQuery() < 1)
                    throw new Exception();
            }
            catch(Exception)
            {
                _return = false;
            }
            finally
            {
                _conn.Close();
            }
            return _return;
        }

        internal List<MiracleDKP.Info> GetNews()
        {
            List<MiracleDKP.Info> _return = new List<MiracleDKP.Info>();
            try
            {
                _conn.Open();
                MySqlCommand _newsCmd =
                    new MySqlCommand("SELECT created_by, date, info FROM infos ORDER BY date DESC;", _conn);
                MySqlDataReader _reader = _newsCmd.ExecuteReader();
                while (_reader.Read())
                {
                    MiracleDKP.Info _info = new MiracleDKP.Info(_reader.GetString(0),
                        _reader.GetDateTime(1).ToString(), _reader.GetString(2));
                    _return.Add(_info);
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                _conn.Close();
            }
            return _return;
        }

        internal bool AddAdmin(string _user, string _pass)
        {
            bool _return = true;
            try
            {
                _conn.Open();
                MySqlCommand _addAdmin = new MySqlCommand("INSERT INTO administrators (user, password, added) VALUES (@User, @Pass, @Added)", _conn);
                MySqlParameter _pUser = new MySqlParameter("@User", _user);
                MySqlParameter _pPass = new MySqlParameter("@Pass", _pass);
                MySqlParameter _pAdded = new MySqlParameter("@Added", _admin);
                _addAdmin.Parameters.Add(_pUser);
                _addAdmin.Parameters.Add(_pPass);
                _addAdmin.Parameters.Add(_pAdded);
                if (_addAdmin.ExecuteNonQuery() < 1)
                    throw new Exception();
            }
            catch (Exception)
            {
                _return = false;
            }
            finally
            {
                _conn.Close();
            }
            return _return;
        }

        internal bool RemAdmin(string _user)
        {
            bool _return = true;
            try
            {
                _conn.Open();

                MySqlCommand _remAdmin = new MySqlCommand("DELETE FROM administrators WHERE user = @User AND added = @Added", _conn);
                MySqlParameter _pUser = new MySqlParameter("@User", _user);
                MySqlParameter _pAdded = new MySqlParameter("@Added", _admin);
                _remAdmin.Parameters.Add(_pUser);
                _remAdmin.Parameters.Add(_pAdded);
                if (_remAdmin.ExecuteNonQuery() < 1)
                    throw new Exception();
            }
            catch (Exception)
            {
                _return = false;
            }
            finally
            {
                _conn.Close();
            }
            return _return;
        }
        
        private void GetAttributes(List<MiracleDKP.CharAttrib> _attribs, string _table, 
            string _col, string _where)
        {
            try
            {
                _conn.Open();
                MySqlCommand _getCmd =
                    new MySqlCommand("SELECT " + _col + " FROM " + _table + 
                        (_where != null ? " WHERE " + _where + ";" : ";"), _conn);
                MySqlDataReader _reader = _getCmd.ExecuteReader();
                while (_reader.Read())
                {
                    MiracleDKP.CharAttrib _attrib =
                        new MiracleDKP.CharAttrib(_reader.GetInt32(0), _reader.GetString(1));
                    _attribs.Add(_attrib);
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                _conn.Close();
            }
        }

        internal List<MiracleDKP.CharAttrib> GetAttributes(string _table)
        {
            List<MiracleDKP.CharAttrib> _attribs = new List<MiracleDKP.CharAttrib>();
            GetAttributes(_attribs, _table, "*", null);
            return _attribs;
        }

        internal List<CharAttrib> GetMainCharacters()
        {
            List<MiracleDKP.CharAttrib> _attribs = new List<MiracleDKP.CharAttrib>();
            GetAttributes(_attribs, "characters", "keycode, name", "is_main = 1");
            return _attribs;
        }

        internal bool AddMember(string p, object p_2, object p_3, object p_4, object p_5, object p_6, object p_7, bool p_8)
        {
            bool _return = true;
            try
            {
                _conn.Open();
                MySqlCommand _addMember = new MySqlCommand(@"INSERT INTO characters (name, class, is_main, 
                role_main, role_alt, profession_main, profession_alt, rank, join_date, added) 
                VALUES (@Name, @Class, @Is_main, @Role_main, @Role_alt, @Prof_main, @Prof_alt, @Rank, @Join_date, @Added)", _conn);
                MySqlParameter _pName = new MySqlParameter("@Name", p);
                MySqlParameter _pClass = new MySqlParameter("@Class", (int)p_2);
                MySqlParameter _pRoleM = new MySqlParameter("@Role_main", (int)p_3);
                MySqlParameter _pRoleA = new MySqlParameter("@Role_alt", (int)p_4);
                MySqlParameter _pProfM = new MySqlParameter("@Prof_main", (int)p_5);
                MySqlParameter _pProfA = new MySqlParameter("@Prof_alt", (int)p_6);
                MySqlParameter _pRank = new MySqlParameter("@Rank", (int)p_7);
                MySqlParameter _pMain = new MySqlParameter("@Is_main", ( p_8 ? 0 : 1 ));
                MySqlParameter _pDate = new MySqlParameter("@Join_date", DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
                MySqlParameter _pAdded = new MySqlParameter("@Added", _admin);
                _addMember.Parameters.Add(_pName);
                _addMember.Parameters.Add(_pClass);
                _addMember.Parameters.Add(_pMain);
                _addMember.Parameters.Add(_pRoleM);
                _addMember.Parameters.Add(_pRoleA);
                _addMember.Parameters.Add(_pProfM);
                _addMember.Parameters.Add(_pProfA);
                _addMember.Parameters.Add(_pRank);
                _addMember.Parameters.Add(_pDate);
                _addMember.Parameters.Add(_pAdded);
                if (_addMember.ExecuteNonQuery() < 1)
                    throw new Exception();
            }
            catch (Exception)
            {
                _return = false;
            }
            finally
            {
                _conn.Close();
            }
            return _return;
        }

        internal bool AddAltChar(string p_1, object p_2)
        {
            bool _return = true;
            try
            {
                MySqlCommand _getUid =
                new MySqlCommand("SELECT id FROM characters WHERE name = @Name;", _conn);
                MySqlParameter _pName = new MySqlParameter("@Name", p_1);
                _getUid.Parameters.Add(_pName);
                int _uid = Int32.Parse(_getUid.ExecuteScalar().ToString());
                
                MySqlCommand _addAlt = new MySqlCommand("INSERT INTO altchars (alt_id, main_id) VALUES (@Alt_id, @Main_id)", _conn);
                MySqlParameter _pMain = new MySqlParameter("@Main_id", (int)p_2);
                MySqlParameter _pAlt = new MySqlParameter("@Alt_id", _getUid);
                _addAlt.Parameters.Add(_pAlt);
                _addAlt.Parameters.Add(_pMain);
                if (_addAlt.ExecuteNonQuery() < 1)
                    throw new Exception();
            }
            catch (Exception)
            {
                _return = false;
            }
            finally
            {
                _conn.Close();
            }
            return _return;
        }
    }
}
