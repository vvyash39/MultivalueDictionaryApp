using System;
using System.Collections.Generic;
using System.Text;

namespace MultivalueDictionaryApp
{
    class ConsoleApplication
    {
        private readonly IMultivalueDictionary<string,string> _multivalueDictionary;
        public ConsoleApplication(IMultivalueDictionary<string, string> multivalueDictionary)
        {
            _multivalueDictionary = multivalueDictionary;
        }

        // Application starting point
        public void Run()
        {
            string commandString;
            bool continueWorking = true;
            while (continueWorking)
            {
                commandString = Console.ReadLine();
                string command = string.Empty, key = string.Empty, value = string.Empty;
                string[] splitValues;
                if (!string.IsNullOrEmpty(commandString))
                {
                    splitValues = commandString.Split(' ');
                    command = splitValues[0];
                    if (!string.IsNullOrEmpty(command))
                    {
                        switch (command.ToUpper())
                        {
                            case "ADD":
                                key = splitValues[1];
                                value = splitValues[2];
                                _multivalueDictionary.Add(key, value);
                                break;

                            case "KEYS":
                                _multivalueDictionary.Keys();
                                break;

                            case "MEMBERS":
                                key = splitValues[1];
                                _multivalueDictionary.Members(key);
                                break;

                            case "REMOVE":
                                key = splitValues[1];
                                value = splitValues[2];
                                _multivalueDictionary.Remove(key, value);
                                break;

                            case "REMOVEALL":
                                key = splitValues[1];
                                _multivalueDictionary.RemoveAll(key);
                                break;

                            case "CLEAR":
                                _multivalueDictionary.Clear();
                                break;

                            case "KEYEXISTS":
                                key = splitValues[1];
                                _multivalueDictionary.KeyExists(key);
                                break;

                            case "MEMBEREXISTS":
                                key = splitValues[1];
                                value = splitValues[2];
                                _multivalueDictionary.MemberExists(key, value);
                                break;

                            case "ALLMEMBERS":
                                _multivalueDictionary.AllMembers();
                                break;

                            case "ITEMS":
                                _multivalueDictionary.Items();
                                break;

                            case "EXIT":
                                Console.WriteLine("Are you sure you want to exit?Press [Y] to exit");
                                var answer = Console.ReadLine().ToUpper();
                                if (answer == "Y")
                                {
                                    continueWorking = false;
                                }
                                else
                                {
                                    continueWorking = true;
                                    Console.WriteLine("Please enter a command");
                                }
                                break;
                            default:
                                Console.WriteLine("Please enter a proper command");
                                break;
                        }
                    }
                }

            }
        }


    }
}
