using System;
using System.IO;
using System.Linq;

namespace ProtobufMinifySharp.Sample
{
    internal static class SampleHelpers
    {
        public const string Generated = "Generated";
        public const string AddressBook = "AddressBook";
        
        public static string GetAncestorDir(string findFile)
        {
            var dir = Environment.CurrentDirectory;
            string path;

            do
            {
                dir = Path.Combine(dir, "..");
                path = Path.Combine(dir, findFile);
                
            } while (!File.Exists(path));

            return dir;
        }

        public static string GetAddressBookPath(string rootDir)
        {
            var objDir = Path.Combine(rootDir, "obj");
            
            return Directory
                .GetFiles(objDir, $"{AddressBook}.cs", SearchOption.AllDirectories)
                .First();
        }

        public static AddressBook CreateAddressBook()
        {
            return new()
            {
                People =
                {
                    new Person
                    {
                        Email = "tom@email.com",
                        Id = 1,
                        Name = "Tom",
                        Phones =
                        {
                            new Person.Types.PhoneNumber
                            {
                                Number = "1-800-555-5555",
                                Type = Person.Types.PhoneType.Work
                            },
                            new Person.Types.PhoneNumber
                            {
                                Number = "867-5309",
                                Type = Person.Types.PhoneType.Home
                            }
                        }
                    },
                    new Person
                    {
                        Email = "taboo@email.com",
                        Id = 2,
                        Name = "Taboo",
                        Phones =
                        {
                            new Person.Types.PhoneNumber
                            {
                                Number = "555-1234",
                                Type = Person.Types.PhoneType.Mobile
                            }
                        },
                        HasThing = true
                    }
                }
            };
        }
    }
}