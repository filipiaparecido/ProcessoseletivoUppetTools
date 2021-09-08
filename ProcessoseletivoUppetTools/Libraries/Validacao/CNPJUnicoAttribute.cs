
//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Threading.Tasks;

//namespace ProcessoseletivoUppetTools.Libraries.Validacao
//{
//    public class CNPJUnicoAttribute : ValidationAttribute
//    {
//        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
//        {
//            string Email = (value as string).Trim();

//            IUsuarioRepository _usuarioRepository = (IUsuarioRepository)validationContext.GetService(typeof(IUsuarioRepository));
//            List<Usuario> usuarios = _usuarioRepository.ObterUsuarioPorEmail(Email);

//            Usuario objusuario = (Usuario)validationContext.ObjectInstance;

//            if (usuarios.Count > 1)
//            {
//                return new ValidationResult("E-mail já existente!");
//            }
//            if (usuarios.Count == 1 && objusuario.UsuarioId != usuarios[0].UsuarioId)
//            {
//                return new ValidationResult("E-mail já existente!");
//            }


//            return ValidationResult.Success;
//        }
//    }
//}