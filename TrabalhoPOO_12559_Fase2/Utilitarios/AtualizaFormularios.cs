//-----------------------------------------------------------------
//    <version>0.1</version>
//    <author>Marco Gramoso</author>
//-----------------------------------------------------------------

namespace TrabalhoPOO_12559_Fase2;

public class AtualizaFormularios
{
    public static void AtualizaTodosOsFormularios()
    {
        foreach (Form form in Application.OpenForms)
        {
            // Verifica se o formulário tem o método AtualizarFormulario e o chama
            if (form is FormMedico formMedico)
            {
                formMedico.AtualizarListaMedicos();
            }
            else if (form is FormViatura formViatura)
            {
                formViatura.AtualizarListaViatura();
            }
            else if (form is FormBombeiro formBombeiro)
            {
                formBombeiro.AtualizarListaBombeiros();
            }
            else if (form is FormCorporacao formCorporacao)
            {
                formCorporacao.AtualizarLista();
            }
            else if (form is FormINEM formINEM)
            {
                formINEM.AtualizarListaViaturas();
                formINEM.AtualizarListaMedicos();
                formINEM.AtualizarListaEnfermeiros();
            }
        }
    }
}


