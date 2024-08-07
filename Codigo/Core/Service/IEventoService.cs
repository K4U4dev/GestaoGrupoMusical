using Core.Datatables;
using Core.DTO;
using System.Net;

namespace Core.Service
{
    public interface IEventoService
    {
        //Vou deixar comentado para quem come�ou a fazer terminar e descomentar apenas quando n�o tiver erro de compila��o
        //Task<HttpStatusCode> RegistrarFrequenciaAsync(List<EventoListaFrequenciaDTO> listaFrequencia);
        Task<HttpStatusCode> Create(Evento evento, IEnumerable<int> idRegentes, int idFigurino);
        HttpStatusCode Delete(int id);
        HttpStatusCode Edit(Evento evento);
        Evento Get(int id);
        ICollection<Eventopessoa> GetEventoPessoasPorIdEvento(int idEvento);
        IEnumerable<Evento> GetAll();
        IEnumerable<EventoDTO> GetAllDTO();
        IEnumerable<EventoIndexDTO> GetAllIndexDTO();
        IEnumerable<EventoIndexDTO> GetAllEventoIndexDTOPerIdGrupoMusical(int idGrupoMusical);
        DatatableResponse<EventoIndexDTO> GetDataPage(DatatableRequest request, int idGrupo);
        HttpStatusCode NotificarEventoViaEmail(IEnumerable<PessoaEnviarEmailDTO> pessoas, int idEvento);
        Task<string> GetNomeInstrumento(int id);
        Task<IEnumerable<FigurinoDropdownDTO>> GetAllFigurinoDropdown(int idGrupo);
        Task<IEnumerable<Eventopessoa>> GetPessoas(int idGrupo);
        Task<HttpStatusCode> CreateApresentacaoInstrumento(Apresentacaotipoinstrumento apresentacaotipoinstrumento);
    }
}
