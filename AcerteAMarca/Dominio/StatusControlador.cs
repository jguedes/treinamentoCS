namespace Dominio
{
    /// <summary>
    ///
    /// StatusControlador representa os possíveis momentos de uma propaganda da promoção. 
    /// Sendo possível os valores "AGUARDANDO", que significa que a propaganda ainda não foi ativada para os telespectadores realizarem suas escolhas de marca.
    /// "ANUNCIADA", significa que as escolhas de marca para o objeto de propaganda da cena está disponível para os telespectadores.
    /// "ACONTECEU", significa que a propagande já aconteceu e começa a contagem regressiva para não permitir mais a interação do telespectador com a cena.
    /// "FINALIZADO", significa que encerrou-se a interação de telespctadores com a cena.
    ///
    /// </summary>
    public enum StatusControlador
    {
        AGUARDANDO,ANUNCIADO,ACONTECEU,FINALIZADO
    }
}