
        [Fact]
        public void Deve_Validar_Se_Nome_Do_Canal_Esta_Vazio_Retornar_Exception()
        {
            // Act & Assert
            var result = Assert.Throws<DomainException>(() => new Canal("", TipoCanal.Audio));
            Assert.Equal("O nome não pode estar vazio!", result.Message);
        }