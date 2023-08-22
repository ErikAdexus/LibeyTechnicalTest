using LibeyTechnicalTestDomain.EFCore;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces;
using LibeyTechnicalTestDomain.LibeyUserAggregate.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Infrastructure
{
    public class LibeyUserRepository : ILibeyUserRepository
    {
        private readonly Context _context;
        public LibeyUserRepository(Context context)
        {
            _context = context;
        }

        public List<LibeyUserResponse> AllLibeyUser()
        {
            var q = from libeyUser in _context.LibeyUsers select new LibeyUserResponse()
            {
                DocumentNumber = libeyUser.DocumentNumber,
                Active = libeyUser.Active,
                Address = libeyUser.Address,
                DocumentTypeId = libeyUser.DocumentTypeId,
                Email = libeyUser.Email,
                FathersLastName = libeyUser.FathersLastName,
                MothersLastName = libeyUser.MothersLastName,
                Name = libeyUser.Name,
                Password = libeyUser.Password,
                Phone = libeyUser.Phone
            };
            var list = q.ToList();
            return list;
        }

        public void Create(LibeyUser libeyUser)
        {
            _context.LibeyUsers.Add(libeyUser);
            _context.SaveChanges();
        }
        public LibeyUserResponse FindResponse(string documentNumber)
        {

            var q = from libeyUser in _context.LibeyUsers.Where(x => x.DocumentNumber.Equals(documentNumber))
                    select new LibeyUserResponse()
                    {
                        DocumentNumber = libeyUser.DocumentNumber,
                        Active = libeyUser.Active,
                        Address = libeyUser.Address,
                        DocumentTypeId = libeyUser.DocumentTypeId,
                        Email = libeyUser.Email,
                        FathersLastName = libeyUser.FathersLastName,
                        MothersLastName = libeyUser.MothersLastName,
                        Name = libeyUser.Name,
                        Password = libeyUser.Password,
                        Phone = libeyUser.Phone
                    };
            var list = q.ToList();
            if (list.Any()) return list.First();
            else return new LibeyUserResponse();
        }
        public void UpdateLibeyUser(string documentNumber, UserUpdateorCreateCommand command)
        {
            //var user = _context.LibeyUsers.Find(documentNumber);
             var user = new LibeyUser(documentNumber, command.DocumentTypeId,
            command.Name,
            command.FathersLastName ,
            command.MothersLastName ,
            command.Address ,
            command.UbigeoCode ,
            command.Phone,
            command.Email,
            command.Password);
            _context.LibeyUsers.Update(user);
            _context.SaveChanges();
        }
        
        public void DeleteLibeyUser(string documentNumber)
        {
            var user = _context.LibeyUsers.Find(documentNumber);
            _context.LibeyUsers.Remove(user);
            _context.SaveChanges();
        }
    }
}