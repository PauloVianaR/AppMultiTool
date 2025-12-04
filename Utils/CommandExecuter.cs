using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data;
using MasterWindowsForms;
using AppMultiTool.Utils.GlobalItems;

namespace AppMultiTool.Utils
{
    public static class CommandExecuter<T>
    {
        private const string defaultCommandReturn = "Comando Inválido!";

        public static ResponseHandler<T> Execute(string command)
        {
            ResponseHandler<T> resp = new();

            try
            {
                if(command.First() == '#' && command.Last() == '#')
                {
                    string target = CommandTarget(command, out string command_base);

                    switch (command_base)
                    {
                        case "bypass":
                            List<string> commands = new()
                            {
                                "auto_clicker",
                                "torrent_downloader",
                                "whatsbot",
                                "contador",
                                "video_audio_downloader",
                                "gen_validator_cpf",
                                "clipboard_copies",
                                "text_converter",
                                "spreadsheet_converter",
                                "media_converter",
                                "routine",
                                "joystick_controller",
                                "playlistmaker",
                                "date_calculator",
                                "clipboardtxt",
                                "playlistcreator",
                                "playlisteditor"
                            };
                            List<Form> forms = new()
                            {
                                Global.Forms.AutoClicker,
                                Global.Forms.TorrentDownloader,
                                Global.Forms.WppBot,
                                Global.Forms.Contador,
                                Global.Forms.VideoAudioDownloader,
                                Global.Forms.GenValidatorCPF,
                                Global.Forms.ClipboardCopies,
                                Global.Forms.TextConverter,
                                Global.Forms.SpreadSheetConverter,
                                Global.Forms.MediaConverter,
                                Global.Forms.Routine,
                                Global.Forms.JoyStickController,
                                Global.Forms.PlaylistMaker,
                                Global.Forms.DateCalculator,
                                Global.Forms.ClipBoardCopiesTxt,
                                Global.Forms.PlayListCreator,
                                Global.Forms.PlayListEditor
                            };

                            int index = commands.IndexOf(target);

                            if (index == -1)
                                throw new Exception(defaultCommandReturn);

                            Form form = forms[index];
                            resp.IsSuccess((T)(object)form);
                            break;
                        case "openweb":
                            string bravepath = @"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe";
                            string args = string.Concat(@"--new-tab https://", target.Replace(@"https://", string.Empty));

                            Process.Start(bravepath, args);
                            resp.IsSuccess((T)(object)true);
                            break;
                        case "math":
                            DataTable table = new();
                            table.Columns.Add("expression", typeof(string), target);
                            DataRow row = table.NewRow();
                            table.Rows.Add(row);
                            double result = double.Parse((string)row["expression"]);

                            resp.IsSuccess((T)(object)result);
                            break;
                        case "say":
                            string msg = command.Replace(string.Concat("#", command_base, " $"), string.Empty).Replace(@"#", string.Empty).Trim();
                            resp.IsSuccess((T)(object)msg);
                            break;
                        case "play":
                            commands = new() { "memory_gods", "chess", "2048","campo_minado","minefield" };
                            List<string> paths = new()
                            {
                                @"D:\PROJETOS PROG HD\MemoriaGods\MemoriaGods\bin\Debug\net5.0-windows\MemoriaGods.exe",
                                @"D:\PROJETOS PROG HD\ChessCSharp\bin\Debug\net5.0-windows\ChessCSharp.exe",
                                @"D:\PROJETOS PROG HD\2048CS\2048CS\bin\Debug\netcoreapp3.1\2048CS.exe",
                                @"D:\PROJETOS PROG HD\CampoMinadoCS\CampoMinadoCS\bin\Debug\netcoreapp3.1\CampoMinadoCS.exe",
                                @"D:\PROJETOS PROG HD\CampoMinadoCS\CampoMinadoCS\bin\Debug\netcoreapp3.1\CampoMinadoCS.exe"
                            };

                            index = commands.IndexOf(target);

                            if (index == -1)
                                throw new Exception(defaultCommandReturn);

                            string path = paths[index];
                            Process.Start(path);
                            resp.IsSuccess((T)(object)true);
                            break;
                        case "copy":
                            commands = new() { "sql1", "sql2" };
                            List<string> sqls = new() 
                            { @"drop procedure if exists RegistraLeituraProducao;
                                drop procedure if exists MarcaPedidoEntregue;
                                drop procedure if exists MarcaPedidosComoEntregue;
                                delimiter ;;
                                create procedure RegistraLeituraProducao(in idppp int)
                                begin
                                    declare sairloop TINYINT DEFAULT 0;
                                    declare idsetorvez int;
    
                                    declare sql_cursor cursor for
                                    select idsetor
                                    from roteiro_producao_etiqueta
                                    where IDPRODPEDPRODUCAO = idppp;
    
                                    declare continue handler for not found set sairloop = 1;
    
                                    open sql_cursor;
	                                sql_loop:loop
	                                if(sairloop = 1) then leave sql_loop;
                                        else 
	                                fetch sql_cursor into idsetorvez;
			
                                            insert into leitura_producao (idprodpedproducao,idsetor,idfuncleitura,dataleitura,prontoroteiro,idfunccadastro)
                                            select idprodpedproducao,idsetorvez,1,now(),if(ULTIMOSETOR = 1,1,0),1
                                            from roteiro_producao_etiqueta
                                            where idprodpedproducao not in
                                            (select idprodpedproducao from leitura_producao where IDSETOR = idsetorvez and idprodpedproducao = idppp)
                                            and idprodpedproducao = idppp
                                            and idsetor = idsetorvez;
                                        end if;
	                                end loop sql_loop;
                                    close sql_cursor;
    
                                    -- registra no setor de ETIQUETA
                                    insert into leitura_producao (idprodpedproducao,idsetor,idfuncleitura,dataleitura,prontoroteiro,idfunccadastro)
	                                select idprodpedproducao,1,1,now(),0,1
                                    from produto_pedido_producao
                                    where not exists
                                    (select idprodpedproducao from leitura_producao where IDSETOR = 1 and idprodpedproducao = idppp)
                                    and idprodpedproducao = idppp;
    
                                    -- registra na expedição
                                    insert into leitura_producao (idprodpedproducao,idsetor,idfuncleitura,dataleitura,prontoroteiro,idfunccadastro)
	                                select idprodpedproducao,6,1,now(),0,1
                                    from produto_pedido_producao
                                    where not exists
                                    (select idprodpedproducao from leitura_producao where IDSETOR = 6 and idprodpedproducao = idppp)
                                    and idprodpedproducao = idppp;
    
                                    update produto_pedido_producao
                                    set SITUACAOPRODUCAO = 3,idsetor = 6
                                    where idprodpedproducao = idppp;
                                end ;;

                                create procedure MarcaPedidoEntregue(in idped int)
                                begin
                                    declare sairloop TINYINT DEFAULT 0;
                                    declare idprodpedproducaovez int;
    
                                    declare sql_cursor CURSOR FOR
                                    select ppp.idprodpedproducao
                                    from produto_pedido_producao ppp
                                    inner join produtos_pedido_espelho ppe on ppe.idprodped = ppp.idprodped
                                    where ppe.IDPEDIDO = idped
                                    and ppp.SITUACAOPRODUCAO <> 3
	                                and ppe.INVISIVELFLUXO = 0
                                    and ppp.IDPRODPEDPRODUCAOPARENT is null;
    
                                    declare continue handler for not found set sairloop = 1;
    
                                    open sql_cursor;
	                                sql_loop:loop
	                                if(sairloop = 1) then leave sql_loop;
                                        else 
	                                fetch sql_cursor into idprodpedproducaovez;			
                                            call RegistraLeituraProducao(idprodpedproducaovez);
                                        end if;
	                                end loop sql_loop;
                                    close sql_cursor;
	
	                                insert into log_alteracao(TABELA,CAMPO,IDREGISTROALT,VALORANTERIOR,VALORATUAL,DATAALT,IDFUNCALT,REFERENCIA,NUMEVENTO) 
                                    select 14, 'Situação Produção: (Ticket 320551)',idpedido, elt(situacaoproducao,if(tipopedido = 2,'-','Etiqueta não Impressa'),'Pendente','Pronto','Entregue'), 'Entregue', now(), 1, 14, 1 
                                    from pedido
                                    where idpedido = idped;
    
                                    update produtos_pedido
                                    set QTDSAIDA = QTDE
                                    where idpedido = idped
                                    and QTDSAIDA < QTDE
                                    and INVISIVELFLUXO = 0;
    
                                    update pedido
                                    set situacao = 5,situacaoproducao = 4
                                    where idpedido = idped;
                                end ;;

                                create procedure MarcaPedidosComoEntregue(in datacadInicio datetime,in datacadFim datetime)
                                begin
                                    declare sairloop TINYINT DEFAULT 0;
                                    declare idpedvez int;
    
                                    declare sql_cursor cursor for
                                    select idpedido
                                    from pedido
                                    where datacad between datacadInicio and datacadFim
                                    and SITUACAOPRODUCAO = 3;
    
                                    declare exit handler for not found set sairloop = 1;
    
                                    open sql_cursor;
                                    sql_loop:loop
                                       if(sairloop = 1) then
                                       leave sql_loop;        
                                       close sql_cursor;
                                        else
	                                fetch sql_cursor into idpedvez;
                                            call MarcaPedidoEntregue(idpedvez);
                                        end if;
                                    end loop sql_loop;
                                end ;;
                                delimiter ;


                                call MarcaPedidosComoEntregue('2024-01-01 00:00:00','2024-03-14 23:59:59');",
                                @"set sql_safe_updates= 0;
                                UPDATE produto_loja 
                                SET 
                                    reserva = 0,
                                    liberacao = 0;

                                drop procedure if exists atualizarReservaLiberacao;
                                drop procedure if exists atualizarReservaLiberacaoLoja;

                                delimiter $$

                                create procedure atualizarReservaLiberacaoLoja(in id_loja int unsigned)
                                begin
                                    declare idProdLoop int unsigned;
                                    declare exit_loop boolean;

	                                -- Busca os produtos que tiverem reserva ou liberação
                                    declare sql_cursor_prod cursor for
                                        SELECT prod.idProd FROM produto prod 
			                                LEFT JOIN subgrupo_prod s ON (prod.IdSubGrupoProd=s.IdSubGrupoProd)
                                            LEFT JOIN grupo_prod g ON (prod.IdGrupoProd=g.IdGrupoProd)
		                                WHERE prod.Situacao=1 
			                                AND COALESCE(s.TipoCalculo, g.TipoCalculo) in (1,5)
		                                GROUP BY prod.idProd;
    
                                    declare continue handler
                                        for not found
                                        set exit_loop = true;

                                    open sql_cursor_prod;
    
	                                set exit_loop = false;
	
	                                -- Percorre os produtos buscados, atualizando a reserva liberação para cada loja
	                                sql_loop_prod : loop
		                                fetch sql_cursor_prod into idProdLoop;
					
		                                if exit_loop then
			                                close sql_cursor_prod;
			                                leave sql_loop_prod;
		                                end if;
					
		                                UPDATE produto_loja SET 
			                                Reserva=( 
				                                SELECT COALESCE(SUM(qtde-qtdsaida),0) 
				                                FROM produtos_pedido pp  
					                                LEFT JOIN pedido p ON (pp.IdPedido=p.IdPedido) 
				                                WHERE (COALESCE(pp.Qtde,0)-COALESCE(pp.QtdSaida,0))>0 
					                                AND pp.InvisivelFluxo=0
					                                AND p.Situacao=7 
					                                AND pp.IdProd=idProdLoop
					                                AND IdLoja=id_loja
					                                AND p.TipoPedido<>4
			                                ) +
                                            (SELECT COALESCE(SUM(pr.Quantidade), 0)
			                                 FROM produto_reserva pr
			                                 WHERE pr.Situacao=1 
				                                AND pr.IdProd=idProdLoop
                                                AND IdLoja=id_loja
			                                ) +        
			                                (SELECT COALESCE(SUM(pte.estoqueTransferir), 0)
			                                FROM produto_transferencia_estoque pte
				                                LEFT JOIN transferencia_estoque te on te.IdTransferencia = pte.IdTransferencia
			                                WHERE te.Situacao = 2 
				                                AND pte.Situacao = 1
				                                AND pte.IdProduto=idProdLoop
				                                AND te.IdLojaOrigem=id_loja), 
			
			                                Liberacao=( 
				                                SELECT COALESCE(SUM(qtde-qtdsaida),0) 
				                                FROM produtos_pedido pp  
					                                LEFT JOIN pedido p ON (pp.IdPedido=p.IdPedido) 
				                                WHERE (COALESCE(pp.Qtde,0)-COALESCE(pp.QtdSaida,0))>0 
					                                AND pp.InvisivelFluxo=0
					                                AND p.Situacao IN(5,8) 
					                                AND p.SituacaoProducao<>4 
					                                AND pp.IdProd=idProdLoop
					                                AND IdLoja=id_loja
					                                AND p.TipoPedido<>4
			                                )
		                                WHERE IdProd=idProdLoop AND IdLoja=id_loja;
		                                commit;
		
	                                end loop;
                                end $$

                                create procedure atualizarReservaLiberacao()
                                begin
                                    declare idLojaLoop int unsigned;
                                    declare exit_loop boolean;

                                    declare sql_cursor cursor for
                                        SELECT idLoja FROM loja WHERE Situacao=1;
    
                                    declare continue handler
                                        for not found
                                        set exit_loop = true;

                                    open sql_cursor;
    
	                                set exit_loop = false;
	
	                                sql_loop : loop
		                                fetch sql_cursor into idLojaLoop;
					
		                                if exit_loop then
			                                close sql_cursor;
			                                leave sql_loop;
		                                end if;
					
		                                call atualizarReservaLiberacaoLoja(idLojaLoop);
		                                commit;
		
	                                end loop;
                                end $$

                                delimiter ;

                                call atualizarReservaLiberacao();
                                drop procedure atualizarReservaLiberacaoLoja;
                                drop procedure atualizarReservaLiberacao;"
                            };

                            index = commands.IndexOf(target);

                            if (index == -1)
                                throw new Exception(defaultCommandReturn);

                            string sql = sqls[index];
                            Clipboard.SetText(sql);
                            msg = "SQL Copiado para a área de transferência!";
                            resp.IsSuccess((T)(object)msg);
                            break;
                        default: 
                            throw new Exception(defaultCommandReturn);
                    }
                }
                else throw new Exception(defaultCommandReturn);
            }
            catch(Exception ex)
            {
                resp.IsNotSuccess(ex.Message);
            }

            return resp;
        }

        public static string CommandTarget(string cmd,out string command_base)
        {
            command_base = cmd.Split(@" $").GetValue(0).ToString().Replace("#", string.Empty).ToLower().Trim();
            return cmd.ToLower().Replace(string.Concat("#", command_base, " $"), string.Empty).Replace(@"#", string.Empty).Trim();
        }

        public static Type GetCommandType(string command)
        {
            List<string> commands = new() { "bypass", "openweb", "math", "say", "copy" };
            List<Type> types = new() { typeof(Form), typeof(bool), typeof(double), typeof(string), typeof(string) };

            var initcmd = command.Replace("#", string.Empty).Split(" $").GetValue(0).ToString();

            if (commands.IndexOf(initcmd) == -1)
                return typeof(bool);

            return types[commands.IndexOf(initcmd)];
        }
    }
}
