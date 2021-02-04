using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //bir class interfacei kullanıyorsa interfaceteki
    //tüm metotları kullanmak barındırmak zorunda
    //interface(Şablon) olduğunu anlamak için ismi I ile başlar
    //interface genellikle operasyonel sınıflar tarafından kullanılır
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
    }
}
