﻿namespace Event_bridge.Model;

public class EventosModel
{
    public int Id { get; set; }
    public int IdUsuario { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }

}
