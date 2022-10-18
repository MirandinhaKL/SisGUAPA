using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace SisGUAPA.Application.Util
{
    public static class FuncoesGerais
    {
        /// <summary>
        /// Cria uma lista  a partir de um enumerador.
        /// </summary>
        public static IList<T> ConverterEnumParaLista<T>()
        {
            IList<T> list = new List<T>();
            Type type = typeof(T);
            if (type != null)
            {
                Array enumValues = Enum.GetValues(type);
                foreach (T value in enumValues)
                {
                    list.Add(value);
                }
            }
            return list;
        }

        /// <summary>
        /// Obem a descrição do item do enumerador.
        /// </summary>
        public static string GetDescricaoEnum(this Enum item)
        {
            Type tipo = item.GetType();
            FieldInfo fi = tipo.GetField(item.ToString());
            DescriptionAttribute[] atributos =
            fi.GetCustomAttributes(typeof(DescriptionAttribute), false)
                    as DescriptionAttribute[];
            if (atributos.Length > 0)
                return atributos[0].Description;
            else
                return string.Empty;
        }

        /// <summary>
        /// Onbtem o valor do enumerador pela Descrição inforamda.
        /// </summary>
        public static T GetEnumPelaDescricao<T>(string description)
        {
            if (!typeof(T).IsEnum)
                throw new Exception("T isn't an enumerated type");

            IList<T> list = ConverterEnumParaLista<T>();
            foreach (T item in list)
            {
                if (((Enum)Enum.Parse(typeof(T),
                       item.ToString())).GetDescricaoEnum() == description)
                    return item;
            }

            throw new Exception("A descrição é inválida.");
        }
    }
}
