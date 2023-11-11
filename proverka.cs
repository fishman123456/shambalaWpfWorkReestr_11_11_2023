using Microsoft.Win32;

namespace shambalaWpfWorkReestr_11_11_2023
{
    // класс для записи и считывания значения реестра
    public static class proverka
    {
        // Процедура, которая проверяет, есть ли запись нужного ключа и значения в реестре
       public static bool IsExecutingBefore(string registryKeyPath, string registryKeyValueName)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(registryKeyPath);
            if (key == null)
            {
                return false;
            }
            object valueName = key.GetValue(registryKeyValueName);
            return valueName != null;
        }

        // Процедура, которая добавляет запись о том, что программа запускалась
        public static void SetExecutingBeforeKey(string registryKeyPath, string registryKeyValueName)
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(registryKeyPath))
            {
                key.SetValue(registryKeyValueName, "1", RegistryValueKind.String);
            }
        }
    }
}
