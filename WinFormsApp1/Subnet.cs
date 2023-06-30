using System.Net;
namespace lab1
{
    public static class Subnet
    {
        // tim dia chi broadcast 
        public static IPAddress GetBroadcastAddress(this IPAddress Address, IPAddress SubnetMask)
        {
            byte[] IpAdressBytes = Address.GetAddressBytes();
            byte[] SubnetMaskBytes = SubnetMask.GetAddressBytes();
            if (IpAdressBytes.Length != SubnetMaskBytes.Length)
                throw new ArgumentException("độ dài subnet mask và địa chỉ ip không bằng nhau.Nhập lại");
            byte[] BroadcastAddress = new byte[IpAdressBytes.Length];
            int length = BroadcastAddress.Length;
            for (int i = 0; i < length; ++i)
                BroadcastAddress[i] = (byte)(IpAdressBytes[i] | (SubnetMaskBytes[i] ^ 255));
            return new IPAddress(BroadcastAddress);
        }
        public static IPAddress GetNetworkAddress(this IPAddress Address, IPAddress SubnetMask)
        {
            byte[] IpAdressBytes = Address.GetAddressBytes();
            byte[] SubnetMaskBytes = SubnetMask.GetAddressBytes();
            if (IpAdressBytes.Length != SubnetMaskBytes.Length)
                throw new ArgumentException("Lengths of IP address and subnet mask do not match.");
            byte[] BroadcastAddress = new byte[IpAdressBytes.Length];
            int length = BroadcastAddress.Length;
            for (int i = 0; i < length; ++i)
                BroadcastAddress[i] = (byte)(IpAdressBytes[i] & (SubnetMaskBytes[i]));
            return new IPAddress(BroadcastAddress);
        }
        public static IPAddress FirstAddress(this IPAddress NetworkAddress)
        {

            byte[] word = NetworkAddress.GetAddressBytes();
            word[word.Length - 1] += (byte)1;
            return new IPAddress(word);
        }
        public static IPAddress LastAddress(this IPAddress NetworkAddress, int Host)
        {
            byte[] word = NetworkAddress.GetAddressBytes();
            word[word.Length - 1] += (byte)(Host);
            return new IPAddress(word);
        }
        public static string[] IPAddrToBinary(this IPAddress ip)
        {
            // assumes a valid IP Address format
            byte[] word = ip.GetAddressBytes();
            int n = word.Length;
            string[] s = new string[n];
            for (int i = 0; i < n; ++i)
            {
                s[i] = Convert.ToString(word[i], 2);
                if (s[i].Length < 8)
                    s[i].PadLeft(8, '0');
            }
            return s;
        }
        public static int CountBitNetwork(this IPAddress SubnetMask)
        {
            int Count = 0;
            string[] Octet = IPAddrToBinary(SubnetMask);
            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    if (Octet[i][j] == '1')
                        Count++;
                    else
                        break;
                }
            }
            return Count;
        }
        public static int CountBitHost(this IPAddress SubnetMask)
        {
            return 32 - SubnetMask.CountBitNetwork();
        }
        public static IPAddress NextIp(this IPAddress IpAddress, int octet, int pos)
        {
            byte[] word = IpAddress.GetAddressBytes();
            word[pos] += (byte)octet;
            return new IPAddress(word);
        }

    }
}
