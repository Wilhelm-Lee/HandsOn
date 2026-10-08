namespace HandsOn;

internal static class Program
{
    private static int Main()
    {
        /* Refactor the @username and @password as @Personnel, an individual class. */
        
        /* Protect @Personnel information from @PersonnelRegistry when being read by using deep copying to prevent Direct-Reference-Modification (DRM). */
        
        /* Implement a inserting method to add new @Personnel information onto @PersonnelRegistry.  (This task has traps.) */
        
        /* Establish a class inheriting @Exception to report RedundantRegistry when the given new @Personnel information is found existing in @PersonnelRegistry. */
        

        PersonnelRegistry pr = new PersonnelRegistry ();
        

        // Implement insert method
        //
        // password invalid
        Personnel p0 = new Personnel("liasda", "--filasdasdae");
        try {
            pr.InsertPersonInformation(PersonnelRegistry.DeepCopy(p0));
        } catch ( Exception e ) {
            Console.WriteLine($"{e.Message}");
        }




        // username invalid
        Personnel p1 = new Personnel("admin", "filasdasdae");
        try {
            pr.InsertPersonInformation(PersonnelRegistry.DeepCopy(p1));
        } catch ( Exception e ) {
            Console.WriteLine($"{e.Message}");
        }




        // valid insert
        Personnel p2 = new Personnel("pinapple", "filasdasdae");
        pr.InsertPersonInformation(PersonnelRegistry.DeepCopy(p2));




        // redundant 
        Personnel p3 = new Personnel("pinapple", "filasdasdae");
        try {
            pr.InsertPersonInformation(PersonnelRegistry.DeepCopy(p3));
        } catch ( Exception e ) {
            Console.WriteLine($"{e.Message}");
        }




        pr.printAccounts();

        Console.WriteLine("-----------------");
        Console.WriteLine("After change Personnel type data:");

        p2.username = "filennasd";
        pr.printAccounts();
        return 0;

    }
}
