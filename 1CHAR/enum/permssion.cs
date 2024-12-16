namespace permssion_namespace
{
    public class testPermission()
    {
        public enum Permission : byte
        {
            NONE = 0x00,
            read = 0x01,
            write = 0x02,
            delete = 0x03,
            create = 0x04,
        }

        protected byte current_permission = (byte)Permission.NONE;

        public string username = "lix";

        public bool checkPermission(Permission checked_permission)
        {
            return (current_permission & (byte)checked_permission) == (byte)checked_permission;
        }

        public void give_permission(Permission new_permission)
        {
            current_permission |= (byte)new_permission;
        }

        public void remove_permission(Permission old_permission)
        {
            if (checkPermission(old_permission))
            {
                current_permission = (byte)((byte)current_permission & ~((byte)old_permission));
            }
            else
            {
                Console.WriteLine("the permission you want to remove does not exist");
            }
        }

        public void run()
        {
            // set the user as
            give_permission(Permission.read);
            give_permission(Permission.write);
            remove_permission(Permission.read);
            remove_permission(Permission.delete);
        }
    }
}
