CREATE TABLE [dbo].[compra] (
    [com_cod]       INT      IDENTITY (1, 1) NOT NULL,
    [com_data]      DATETIME NULL,
    [com_nfiscal]   INT      NULL,
    [com_total]     MONEY    NULL,
    [com_nparcelas] INT      NULL,
    [com_status]    NVARCHAR(95)      NULL,
    [for_cod]       INT      NULL,
    [tpa_cod]       INT      NULL,
    CONSTRAINT [XPKcompra] PRIMARY KEY NONCLUSTERED ([com_cod] ASC),
    CONSTRAINT [R_21] FOREIGN KEY ([for_cod]) REFERENCES [dbo].[fornecedor] ([for_cod]),
    CONSTRAINT [R_24] FOREIGN KEY ([tpa_cod]) REFERENCES [dbo].[tipopagamento] ([tpa_cod])
);

