# MultivalueDictionaryApp
A console app emulating a Multi-value dictionary built using .Net framework 4.6.1 and written in C#.
Uses Unity Container to inject dependencies.  
Has the following commands 
#### ADD [key] [value]
Adds the the value for a given key. If the key does not exist,adds the key along with the value.
Throws an error, if the key value pair already exists  
#### MEMBERS [key]  
Returns the collection of strings or values for a given key
#### KEYS
Returns all the keys in the dictionary  
#### REMOVE [key] [value]
Removes a member from a key. If the last member is removed from the key, the key is removed from the dictionary. If the key or member does not exist, displays an
error.  
#### REMOVEALL [key]
Removes all members for a key and removes the key from the dictionary. Returns an error if the key does not exist.  
#### CLEAR  
Removes all keys and all members from the dictionary.  
#### KEYEXISTS [key]
Returns whether a key exists or not.  
#### MEMBEREXISTS [key] [value]
Returns whether a member exists within a key. Returns false if the key does not exist.  
#### ALLMEMBERS  
Returns all the members in the dictionary. Returns nothing if there are none.  
#### ITEMS  
Returns all keys in the dictionary and all of their members. Returns nothing if there are none.  
#### EXIT  
Prompts for user input to exit the app.

