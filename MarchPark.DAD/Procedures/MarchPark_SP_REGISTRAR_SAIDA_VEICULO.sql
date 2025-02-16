USE [PROJETOS]
GO
/****** Object:  StoredProcedure [dbo].[MarchPark_SP_REGISTRAR_SAIDA_VEICULO]    Script Date: 29/12/2024 17:22:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[MarchPark_SP_REGISTRAR_SAIDA_VEICULO]
    @id_entrada INT,       -- Parâmetros
	@id_cliente INT, 
    @id_veiculo INT,	   --
	@entrada DATETIME,	   --
	@tarifa DECIMAL(5, 2)  --
AS
BEGIN
    -- Corpo da procedure

	-- Variavéis locais
	DECLARE @horas_totais DECIMAL(10, 2);
	DECLARE @valor_total DECIMAL(10, 2);
	DECLARE @saida DATETIME = CONVERT(DATETIME, GETDATE(), 120);

	-- Tabela temporária para calcular o valor a pagar.
	CREATE TABLE #TBL_CALCULO_VALOR (
        ENTRADA DATETIME,
        SAIDA DATETIME
    );

	-- Inserindo a hora de entrada e saída na tabela temporária para calcular.
	INSERT INTO #TBL_CALCULO_VALOR
	VALUES (@entrada, @saida)

	-- Selecionando o total de segundos que o clente ficou com o veículo estacionado.
	SELECT 
        @horas_totais = CAST(DATEDIFF(SECOND, ENTRADA, SAIDA) AS FLOAT) / 3600
    FROM #TBL_CALCULO_VALOR

	-- Fazendo o calculo do valor a ser pago seguindo as condições.
	IF @horas_totais <= 1
		BEGIN
			-- Tarifa cheia para até 1 hora
			SET @valor_total = @tarifa;
		END
	ELSE
		BEGIN
			-- Tarifa cheia para a primeira hora e metade para as demais
			SET @valor_total = @tarifa + ((CONVERT(INT, @horas_totais)) * (@tarifa / 2));
		END

	-- Inserindo na tabela de histórico a saída do veículo.
	INSERT INTO MarchPark_TBL_HISTORICO
	VALUES (@id_cliente, 
			@id_veiculo, 
			@valor_total, 
			@entrada, 
			@saida, 
			(SELECT 
				 COUNT(*) + 1
			 FROM MarchPark_TBL_HISTORICO AS H
			 WHERE FORMAT(H.ENTRADA, 'yyyy-MM-dd') = FORMAT(@entrada, 'yyyy-MM-dd'))
			 )

	-- Deletando da tabela de entrada.
	DELETE FROM MarchPark_TBL_ENTRADA
	WHERE ID_ENTRADA = @id_entrada

	-- Deletando a tabela temporária.
	DROP TABLE #TBL_CALCULO_VALOR;
END;