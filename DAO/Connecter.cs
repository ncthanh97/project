using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class sqlConnectionData
    {
        public static SqlConnection Connecter()
        {
            SqlConnection connecter = new SqlConnection("Server=DESKTOP-9NQIKL1; Database=Manage_Cinema; Trusted_Connection=True");
            return connecter;
        }
    }
    public class Movie_DAO
    {
        //Show list movie
        public static DataTable ListMovie()
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("ListMovie", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(commander);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        //Add movie
        public static void AddMovie(Movie_DTO movie)
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("AddMovie", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.Add("@id", SqlDbType.Char, 10).Value = movie.IdMovie;
            commander.Parameters.Add("@name", SqlDbType.NVarChar, 1000).Value = movie.Name;
            commander.Parameters.Add("@genres", SqlDbType.NVarChar, 1000).Value = movie.Genres;
            commander.Parameters.Add("@director", SqlDbType.NVarChar, 1000).Value = movie.Director;
            commander.Parameters.Add("@actor", SqlDbType.NVarChar, 1000).Value = movie.Actor;
            commander.Parameters.Add("@duration", SqlDbType.NVarChar, 20).Value = movie.Duration;
            commander.Parameters.Add("@releaseDay", SqlDbType.Date).Value = movie.ReleaseDay;
            commander.Parameters.Add("@languages", SqlDbType.NVarChar, 1000).Value = movie.Language;
            commander.Parameters.Add("@country", SqlDbType.NVarChar, 1000).Value = movie.Country;
            commander.Parameters.Add("@rated", SqlDbType.NVarChar, 100).Value = movie.Rated;

            connecter.Open();
            commander.ExecuteNonQuery();
            connecter.Close();
        }

        //Delete Movie
        public static void DeleteMovie(string idmovie)
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("DeleteMovie", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.Add("@idmovie", SqlDbType.Char, 10);
            commander.Parameters["@idmovie"].Value = idmovie;
            connecter.Open();
            commander.ExecuteNonQuery();
            connecter.Close();
        }
        //Find a movie by id
        public static DataTable FindMovieById(string idmovie)
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("FindMovieById", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.Add("@idmovie", SqlDbType.Char, 10);
            commander.Parameters["@idmovie"].Value = idmovie;
            SqlDataAdapter adapter = new SqlDataAdapter(commander);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        //Find a movie by name
        public static DataTable FindMovieByName(string name)
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("FindMovieByName", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.Add("@name", SqlDbType.NVarChar, 100);
            commander.Parameters["@name"].Value = name;
            SqlDataAdapter adapter = new SqlDataAdapter(commander);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
    }
    public class Staff_DAO
    {
        //Show all staffs
        public static DataTable ListStaff()
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("ListStaff", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(commander);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        //Add a staff
        public static void AddStaff(Staff_DTO staff)
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("AddStaff", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.Add("@id", SqlDbType.Char, 10).Value = staff.IdStaff;
            commander.Parameters.Add("@firstname", SqlDbType.NVarChar, 100).Value = staff.FirstName;
            commander.Parameters.Add("@lastname", SqlDbType.NVarChar, 100).Value = staff.LastName;
            commander.Parameters.Add("@birthday", SqlDbType.Date).Value = staff.Birthday;
            commander.Parameters.Add("@sex", SqlDbType.NVarChar, 6).Value = staff.Sex;
            commander.Parameters.Add("@placeOfBirth", SqlDbType.NVarChar, 50).Value = staff.PlaceOfBirth;
            commander.Parameters.Add("@address1", SqlDbType.NVarChar, 100).Value = staff.Address;
            commander.Parameters.Add("@identityNumber", SqlDbType.Char, 20).Value = staff.IdentityNumber;
            commander.Parameters.Add("@email", SqlDbType.NVarChar, 100).Value = staff.Email;
            commander.Parameters.Add("@position", SqlDbType.NVarChar, 50).Value = staff.Position;
            commander.Parameters.Add("@phoneNumber", SqlDbType.NVarChar, 20).Value = staff.PhoneNumber;

            connecter.Open();
            commander.ExecuteNonQuery();
            connecter.Close();
        }
        //Delete a staff
        public static void DeleteStaff(string idstaff)
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("DeleteAStaff", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.Add("@idstaff", SqlDbType.Char, 10).Value = idstaff;
            connecter.Open();
            commander.ExecuteNonQuery();
            connecter.Close();
        }
        //Find staff by id
        public static DataTable FindStaffById(string idstaff)
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("FindStaffById", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.Add("@idstaff", SqlDbType.Char, 10).Value = idstaff;
            SqlDataAdapter adapter = new SqlDataAdapter(commander);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        //Find staff by name
        public static DataTable FindStaffByName(string name)
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("FindStaffByName", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.Add("@name", SqlDbType.Char, 100).Value = name;
            SqlDataAdapter adapter = new SqlDataAdapter(commander);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
    }
    public class User_DAO
    {
        //Show list users
        public static DataTable ListUser()
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("ListUser", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(commander);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        //Add a user
        public static void AddUser(User_DTO user)
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("AddUser", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.Add("@id", SqlDbType.Char, 10).Value = user.IdUser;
            commander.Parameters.Add("@firstName", SqlDbType.NVarChar, 100).Value = user.FirstName;
            commander.Parameters.Add("@lastName", SqlDbType.NVarChar, 100).Value = user.LastName;
            commander.Parameters.Add("@sex", SqlDbType.NVarChar, 6).Value = user.Sex;
            commander.Parameters.Add("@birthday", SqlDbType.Date).Value = user.Birthday;
            commander.Parameters.Add("@phoneNumber", SqlDbType.Char, 20).Value = user.PhoneNumber;
            commander.Parameters.Add("@identityNumber", SqlDbType.Char, 20).Value = user.IdentityNumber;
            commander.Parameters.Add("@email", SqlDbType.NVarChar, 100).Value = user.Email;

            connecter.Open();
            commander.ExecuteNonQuery();
            connecter.Close();
        }
        //Delete user
        public static void DeleteUser(string id)
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("DeleteUser", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.Add("@id", SqlDbType.Char, 10).Value = id;
            connecter.Open();
            commander.ExecuteNonQuery();
            connecter.Close();
        }
        //Find user by id
        public static DataTable FindUserById(string id)
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("FindUserById", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.Add("@id", SqlDbType.Char, 10).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(commander);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        //Find user by name
        public static DataTable FindUserByName(string name)
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("FindUserByName", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.Add("@name", SqlDbType.Char, 100).Value = name;
            SqlDataAdapter adapter = new SqlDataAdapter(commander);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
    }
    public class Room_DAO
    {
        //Show all rooms
        public static DataTable ListRoom()
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("ListRoom", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(commander);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        //Add a room
        public static void AddRoom(Room_DTO room)
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("AddRoom", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.Add("@id", SqlDbType.Char, 10).Value = room.Id;
            commander.Parameters.Add("@sn", SqlDbType.Int).Value = room.Seatnumber;
            commander.Parameters.Add("@area", SqlDbType.VarChar, 20).Value = room.Area;
            commander.Parameters.Add("@status", SqlDbType.NVarChar, 50).Value = room.Status;

            connecter.Open();
            commander.ExecuteNonQuery();
            connecter.Close();
        }
        //Find room by id
        public static DataTable FindRoomById(string id)
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("FindRoomById", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.Add("@id", SqlDbType.Char, 10).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(commander);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        //Delete room
        public static void DeleteRoom(string id)
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("DeleteRoom", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.Add("@id", SqlDbType.Char, 10).Value = id;
            connecter.Open();
            commander.ExecuteNonQuery();
            connecter.Close();
        }
    }
    public class Showtime_DAO
    {
        //Show all showtimes
        public static DataTable ListShowTime()
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("ListShowTime", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(commander);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        //Add a showtime
        public static void AddShowTime(Showtime_DTO showtime)
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("AddShowTime", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.Add("@id", SqlDbType.Char, 10).Value = showtime.Id;
            commander.Parameters.Add("@time", SqlDbType.Time).Value = showtime.Time;
            commander.Parameters.Add("@day", SqlDbType.Date).Value = showtime.Date;
            commander.Parameters.Add("@tn", SqlDbType.Int).Value = showtime.Ticketnumber;
            commander.Parameters.Add("@idm", SqlDbType.Char, 10).Value = showtime.Idmovie;
            commander.Parameters.Add("@idr", SqlDbType.Char, 10).Value = showtime.Idroom;

            connecter.Open();
            commander.ExecuteNonQuery();
            connecter.Close();
        }
        //Find showtime by id
        public static DataTable FindShowTimeById(string id)
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("FindShowTime", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.Add("@id", SqlDbType.Char, 10).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(commander);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        //Delete a showtime
        public static void DeleteShowtime(string id)
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("DeleteShowtime", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.Add("@id", SqlDbType.Char, 10).Value = id;
            connecter.Open();
            commander.ExecuteNonQuery();
            connecter.Close();
        }
    }
    public class TicketType_DAO
    {
        //Show all ticket type
        public static DataTable ListTicketType()
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("ListTicketType", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(commander);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        //Add a ticket type
        public static void AddTicketType(TicketType_DTO ticketType)
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("AddTicketType", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.Add("@id", SqlDbType.Char, 10).Value = ticketType.Id;
            commander.Parameters.Add("@cdt", SqlDbType.NVarChar, 500).Value = ticketType.Condition;
            commander.Parameters.Add("@price", SqlDbType.Int).Value = ticketType.Price;

            connecter.Open();
            commander.ExecuteNonQuery();
            connecter.Close();
        }
        //Find ticket type
        public static DataTable FindTicketType(string id)
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("FindTicketType", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.Add("@id", SqlDbType.Char, 10).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(commander);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        //Delete ticket type
        public static void DeleteTicketType(string id)
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("DeleteTicketType", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.Add("@id", SqlDbType.Char, 10).Value = id;
            connecter.Open();
            commander.ExecuteNonQuery();
            connecter.Close();
        }
    }
    public class TicketWasSold_DAO
    {
        //Show all ticket was sold
        public static DataTable ListTWS()
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("TicketWasSold", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(commander);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        //Get seat number was taken
        public static List<String> getSeatWasTaken(string id)
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("GetPosition", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.Add("@idShowtime", SqlDbType.Char, 10).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(commander);
            DataTable data = new DataTable();
            adapter.Fill(data);
            List<string> seats = new List<string>();
            for (int i = 1; i < data.Rows.Count; i++)
            {
                seats.Add(data.Rows[i][0].ToString());
            }
            return seats;
        }
        //Sell ticket
        public static void SellTicket(TicketWasSold_DTO ticket)
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("SellTicket", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.Add("@idm", SqlDbType.Char, 10).Value = ticket.Idmovie;
            commander.Parameters.Add("@nMovie", SqlDbType.NVarChar, 1000).Value = ticket.Namemovie;
            commander.Parameters.Add("@idr", SqlDbType.Char, 10).Value = ticket.Idroom;
            commander.Parameters.Add("@ids", SqlDbType.Char, 10).Value = ticket.Idshowtime;
            commander.Parameters.Add("@idt", SqlDbType.Char, 10).Value = ticket.Idticket;
            commander.Parameters.Add("@pos", SqlDbType.Char, 5).Value = ticket.Position;
            commander.Parameters.Add("@time", SqlDbType.Time).Value = ticket.Time;
            commander.Parameters.Add("@day", SqlDbType.Date).Value = ticket.Day;

            connecter.Open();
            commander.ExecuteNonQuery();
            connecter.Close();
        }
        //Find ticket was sold by name movie
        public static DataTable FindTWSByNameMovie(string name)
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("FindTWSByNameMovie", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.Add("@name", SqlDbType.NVarChar, 1000).Value = name;
            SqlDataAdapter adapter = new SqlDataAdapter(commander);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        //Find ticket was sold by id movie
        public static DataTable FindTWSByIdMovie(string id)
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("FindTWSByIdMovie", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.Add("@id", SqlDbType.Char, 10).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(commander);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        //Find ticket was sold by id room
        public static DataTable FindTWSByIdRoom(string id)
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("FindTWSByIdRoom", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.Add("@id", SqlDbType.Char, 10).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(commander);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        //Find ticket was sold by id showtime
        public static DataTable FindTWSByIdShowtime(string id)
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("FindTWSByIdShowtime", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.Add("@id", SqlDbType.Char, 10).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(commander);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        //Delete ticket
        public static void DeleteTWS(string id)
        {
            SqlConnection connecter = sqlConnectionData.Connecter();
            SqlCommand commander = new SqlCommand("DeleteTicket", connecter);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.Add("@id", SqlDbType.Char, 10).Value = id;
            connecter.Open();
            commander.ExecuteNonQuery();
            connecter.Close();
        }
    }

}

