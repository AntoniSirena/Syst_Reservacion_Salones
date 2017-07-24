using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CapaDato
{
    public class Encriptar
    {


        string key = "ABCDEFG54669525PQRSTUVWXYZabcdef852846opqrstuvwxyz";

        //ENCRIPTA CONTRASEÑA
        public string EncryptKey(string cadena)
        {
            //arreglo de bytes donde guardaremos la llave

            byte[] keyArray;

            //arreglo de bytes donde guardaremos el texto

            //que vamos a encriptar

            byte[] Arreglo_a_Cifrar = UTF8Encoding.UTF8.GetBytes(cadena);

            //se utilizan las clases de encriptación

            //provistas por el Framework

            //Algoritmo MD5

            MD5CryptoServiceProvider hashASHA = new MD5CryptoServiceProvider();
            //se guarda la llave para que se le realice

            //hashing
            keyArray = hashASHA.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));

            hashASHA.Clear();

            //Algoritmo 3DAS

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

            tdes.Key = keyArray;

            tdes.Mode = CipherMode.ECB;

            tdes.Padding = PaddingMode.PKCS7;

            //se empieza con la transformación de la cadena

            ICryptoTransform cTransform = tdes.CreateEncryptor();

            //arreglo de bytes donde se guarda la

            //cadena cifrada

            byte[] ArrayResultado = cTransform.TransformFinalBlock(Arreglo_a_Cifrar, 0, Arreglo_a_Cifrar.Length);

            tdes.Clear();

            //se regresa el resultado en forma de una cadena

            return Convert.ToBase64String(ArrayResultado, 0, ArrayResultado.Length);
        }
    }
}
