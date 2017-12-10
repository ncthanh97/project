using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAO;

namespace BUS
{
    public class Movie_BUS
    {
        //Show List Movie
        public static DataTable ListMovie()
        {
            return Movie_DAO.ListMovie();
        }

        //Add Movie
        public static void AddMovie(Movie_DTO movie)
        {
            Movie_DAO.AddMovie(movie);
        }

        //Edit info movie
        public static void EditMovie(Movie_DTO movie)
        {
            Movie_DAO.EditMovie(movie);
        }

        //Delete Movie
        public static void DeleteMovie(string idmovie)
        {
            Movie_DAO.DeleteMovie(idmovie);
        }

        //Find Movie By Id
        public static DataTable FindMovieById(string idmovie)
        {
            return Movie_DAO.FindMovieById(idmovie);
        }
        //Find Movie By Name
        public static DataTable FindMovieByName(string name)
        {
            return Movie_DAO.FindMovieByName(name);
        }
    }
    public class Staff_BUS
    {
        //Show liststaff
        public static DataTable ListStaff()
        {
            return Staff_DAO.ListStaff();
        }
        //Add a staff
        public static void AddStaff(Staff_DTO staff)
        {
            Staff_DAO.AddStaff(staff);
        }
        //Edit info staff
        public static void EditStaff(Staff_DTO staff)
        {
            Staff_DAO.EditStaff(staff);
        }

        //Delete a staff
        public static void DeleteStaff(string idstaff)
        {
            Staff_DAO.DeleteStaff(idstaff);
        }
        //Find staff by id
        public static DataTable FindStaffById(string idstaff)
        {
            return Staff_DAO.FindStaffById(idstaff);
        }
        //Find staff by name
        public static DataTable FindStaffByName(string name)
        {
            return Staff_DAO.FindStaffByName(name);
        }
    }
    public class User_BUS
    {
        //Show list users
        public static DataTable ListUsers()
        {
            return User_DAO.ListUser();
        }
        //Add a user
        public static void AddUser(User_DTO user)
        {
            User_DAO.AddUser(user);
        }
        //Edit info user
        public static void EditUser(User_DTO user)
        {
            User_DAO.EditUser(user);
        }

        //Find a user by id
        public static DataTable FindUserById(string id)
        {
            return User_DAO.FindUserById(id);
        }
        //Find a user by name
        public static DataTable FindUserByName(string name)
        {
            return User_DAO.FindUserByName(name);
        }
        //Delete user
        public static void DeleteUser(string id)
        {
            User_DAO.DeleteUser(id);
        }
    }
    public class Room_BUS
    {
        //Show all rooms
        public static DataTable ListRoom()
        {
            return Room_DAO.ListRoom();
        }
        //Add a room
        public static void AddRoom(Room_DTO room)
        {
            Room_DAO.AddRoom(room);
        }
        //Edit info room
        public static void EditRoom(Room_DTO room)
        {
            Room_DAO.EditRoom(room);
        }

        //Find room by id
        public static DataTable FindRoomById(string id)
        {
            return Room_DAO.FindRoomById(id);
        }
        //Delete room
        public static void DeleteRoom(string id)
        {
            Room_DAO.DeleteRoom(id);
        }
    }
    public class Showtime_BUS
    {
        //Show all showtime
        public static DataTable ListShowtime()
        {
            return Showtime_DAO.ListShowTime();
        }

        public static DataTable ListShowtimeSold()
        {
            return Showtime_DAO.ListShowTimeSold();
        }
        //Add a showtime
        public static void AddShowtime(Showtime_DTO showtime)
        {
            Showtime_DAO.AddShowTime(showtime);
        }
        //Edit info showtime
        public static void EditShowtime(Showtime_DTO showtime)
        {
            Showtime_DAO.EditShowTime(showtime);
        }

        //Find a showtime by id
        public static DataTable FindShowtimeById(string id)
        {
            return Showtime_DAO.FindShowTimeById(id);
        }

        public static DataTable FindShowtimeByIdMovie(string id)
        {
            return Showtime_DAO.FindShowTimeByIdMovie(id);
        }

        //Delete a showtime
        public static void DeleteShowtime(string id)
        {
            Showtime_DAO.DeleteShowtime(id);
        }
    }
    public class TicketType_BUS
    {
        //Show all ticket type
        public static DataTable ListTicketType()
        {
            return TicketType_DAO.ListTicketType();
        }
        //Add a ticket type
        public static void AddTicketType(TicketType_DTO ticket)
        {
            TicketType_DAO.AddTicketType(ticket);
        }
        //Edit info ticket type
        public static void EditTicketType(TicketType_DTO ticket)
        {
            TicketType_DAO.EditTicketType(ticket);
        }

        //Find a ticket type
        public static DataTable FindTicketType(string id)
        {
            return TicketType_DAO.FindTicketType(id);
        }
        //Delete a ticket type
        public static void DeleteTicketType(string id)
        {
            TicketType_DAO.DeleteTicketType(id);
        }
    }
    public class TicketWasSold_BUS
    {
        public static DataTable ListTWS()
        {
            return TicketWasSold_DAO.ListTWS();
        }
        public static void SellTicket(TicketWasSold_DTO ticket)
        {
            TicketWasSold_DAO.SellTicket(ticket);
        }
        public static DataTable FindTWSByNameMovie(string name)
        {
            return TicketWasSold_DAO.FindTWSByNameMovie(name);
        }
        public static DataTable FindTWSByIdMovie(string id)
        {
            return TicketWasSold_DAO.FindTWSByIdMovie(id);
        }
        public static DataTable FindTWSByIdRoom(string id)
        {
            return TicketWasSold_DAO.FindTWSByIdRoom(id);
        }
        public static DataTable FindTWSByIdShowtime(string id)
        {
            return TicketWasSold_DAO.FindTWSByIdShowtime(id);
        }
        public static void DeleteTicket(string id)
        {
            TicketWasSold_DAO.DeleteTWS(id);
        }
        public static DataTable seatWasTaken(string id)
        {
            return TicketWasSold_DAO.getSeatWasTaken(id);
        }
    }

    public class Salary_BUS
    {
        public static DataTable ListSalary()
        {
            return Salary_DAO.ListSalary();
        }

        public static void AddSalary(Salary_DTO salary)
        {
            Salary_DAO.AddSalary(salary);
        }

        public static void EditSalary(Salary_DTO salary)
        {
            Salary_DAO.EditSalary(salary);
        }

        public static DataTable FindSalary(string position)
        {
            return Salary_DAO.FindSalary(position);
        }

        public static void DeleteSalary(string position)
        {
            Salary_DAO.DeleteSalary(position);
        }

    }

    public class Account_BUS
    {
        public static DataTable ListAccount()
        {
            return Account_DAO.ListAccount();
        }

        public static void AddAccount(Account_DTO acc)
        {
            Account_DAO.AddAccount(acc);
        }

        public static void EditAccount(Account_DTO acc)
        {
            Account_DAO.EditAccount(acc);
        }

        public static DataTable FindAccount(string id)
        {
            return Account_DAO.FindAccountById(id);
        }

        public static void DeleteAccount(string id)
        {
            Account_DAO.DeleteAccount(id);
        }

        public static void ChangePassword(string id, string pw)
        {
            Account_DAO.ChangePassword(id, pw);
        }
    }
}
