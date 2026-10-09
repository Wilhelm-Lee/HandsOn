namespace HandsOn;

public class PersonnelRegistry
{
    private Dictionary<string, string> accounts = new();

    public void printAccounts()
    {
        foreach (var account in accounts)
        {
            Console.WriteLine(
                "username: " + account.Key
                             + "  " +
                             "password: " + account.Value);
        }
    }

    public void CheckValid(Personnel person)
    {
        
        if (!handleUsernameFunction(person.username))
        {
            throw new InvalidUsernameException();
        }

        if (!handlePasswordFunction(person.password))
        {
            throw new InvalidPasswordException();
        }

    }


    // throw three kinds error
    public void InsertPersonInformation(Personnel person)
    {
        Personnel copy = DeepCopy(person);
        
        this.CheckValid(copy);

        if (accounts.ContainsKey(copy.username))
        {
            throw new RedundantRegistryException();
        }

        this.accounts[copy.username] = copy.password;
    }


    public static Personnel DeepCopy(Personnel person)
    {
        return new Personnel((string)person.username.Clone(), (string)person.password.Clone());
    }


    // public PersonnelRegistry(string username, string password)
    // {
    //     if (!handleUsernameFunction(username))
    //     {
    //         throw InvalidUsernameException;
    //     }
    //
    //     if (!handlePasswordFunction(password))
    //     {
    //         throw InvalidPasswordException;
    //     }
    //
    //     this.username = username;
    //     this.password = password;
    // }


    private bool handleUsernameFunction(string username)
    {
        if (username == null)
        {
            return false;
        }

        string usernameTrim = username.Trim();
        if (usernameTrim.Length < 3)
        {
            return false;
        }

        if (usernameTrim == "admin" || usernameTrim == "banana" ||
            usernameTrim == "null")
        {
            return false;
        }

        return true;
    }

    private bool handlePasswordFunction(string password)
    {
        if (password == null)
        {
            return false;
        }

        string passwordTrim = password.Trim();
        if (passwordTrim.Length < 8)
        {
            return false;
        }

        if (findSpecialChar(passwordTrim))
        {
            return false;
        }

        return true;
    }

    private bool findSpecialChar(string strings)
    {
        foreach (char c in strings)
        {
            if ((c > 20 && c < 48) || (c > 57 && c < 65) ||
                (c > 90 && c < 97) || (c > 122 && c < 127))
            {
                return true;
            }
        }

        return false;
    }

    // public PersonnelRegistry? DeepCopy(PersonnelRegistry? registry)
    // {
    //     if (registry is null)
    //     {
    //         return null;
    //     }
    //
    //     return new PersonnelRegistry((string)registry.username.Clone(),
    //         (string)registry.password.Clone());
    // }
    //
    // public string GetUsername()
    // {
    //     return username;
    // }
    //
    // public string GetPassword()
    // {
    //     return password;
    // }
    //
    // public void SetUsername(string username)
    // {
    //     this.username = username;
    // }
    //
    // public void SetPassword(string password)
    // {
    //     this.password = password;
    // }

    /* username:  cannot be empty, pure whitespace-blank, less than 3 characters long, or have the following reserved words:
     *   1. null
     *   2. admin
     *   3. banana
     */

    /*
     * password:  cannot be empty, pure whitespace-blank, less than 8 characters long, or have any special symbols other than a-zA-Z0-9.
     */

    /* for every error that may occur, throw the corresponding exception. */
}