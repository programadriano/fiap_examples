using Domain.Entities;
using System;
using TechTalk.SpecFlow;

namespace Domain.Tests
{
    [Binding]
    public class CanaisDeComunicacaoStepDefinitions
    {
        private  string NomeCanal;
        private  int TipoCanal;
        private Canal canal;

        [Given(@"que preciso cadastrar um canal de audio ou video")]
        public void GivenQuePrecisoCadastrarUmCanalDeAudioOuVideo()
        {
           
        }

        [When(@"preencho o campo Nome com ""([^""]*)"" e o tipo como (.*)")]
        public void WhenPreenchoOCampoNomeComEOTipoComo(string p0, int p1)
        {
            NomeCanal = p0;
            TipoCanal = p1;           
        }


        [When(@"recebo os dados preenchidos pela tela")]
        public void WhenReceboOsDadosPreenchidosPelaTela()
        {
            Assert.Equal(NomeCanal, "Canal de Video");
            Assert.Equal(TipoCanal, 1);
        }

        [Then(@"cadastro um novo Canal de video")]
        public void ThenCadastroUmNovoCanalDeVideo()
        {
            canal = new Canal(NomeCanal, TipoCanal);
        }

          
        [Then(@"o canal ""([^""]*)"" aparece na listagem de canais cadastrados")]
        public void ThenOCanalApareceNaListagemDeCanaisCadastrados(string p0)
        {
            Assert.Equal(NomeCanal, canal.Nome);
        }

    }
}
