using System;

public class ClNecesidadCliente
{
	public ClNecesidadCliente()
	{

         public int CLNecesidadCliente { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public string Direccion { get; set; }
    public string Ciudad { get; set; }
    public string email { get; set; }
    public string FechaNacimiento { get; set; }
    public string Cedula { get; set; }
    public string Telefono { get; set; }
    public DateTime TiempoEntrega { get; set; }
    public int idNecesidadCliente { get; set; }

    clConexion objConexion;
    public List<clEmpleado> mtdListar()


    { string consulta = ("select * from NecesidadCliente");
    DataTable tblResultado = new DataTable();
    objConexion = new clConexion();
    tblResultado = objConexion.mtdDesconectado(consulta);



    List<clNecesidadCliente> listNecesidadCliente = new List<clNecesidadCliente>();
    for (int i = 0; i<tblResultado.Rows.Count; i++)

        {
        clNecesidadCliente objNecesidadCliente = new clNecesidadCliente();
    objNecesidadCliente.idNecesidadCliente = int.Parse(tblResultado.Rows[i]["idNecesidadCliente"].ToString());
    objNecesidadCliente.Nombres = tblResultado.Rows[i]["Nombres"].ToString();
    objNecesidadCliente.Apellidos = tblResultado.Rows[i]["Apellidos"].ToString();
    objNecesidadCliente.Direccion = tblResultado.Rows[i]["Direccion"].ToString();
    objNecesidadCliente.TiempoEntrega = DateTime.Parse(tblResultado.Rows[i]["TiempoEntrega"].ToString());
                objNecesidadCliente.Ciudad = tblResultado.Rows[i]["Ciudad"].ToString();
    objNecesidadCliente.Email = tblResultado.Rows[i]["Email"].ToString();
    objNecesidadCliente.FechaNacimiento = tblResultado.Rows[i]["FechaNacimiento"].ToString();
    objNecesidadCliente.Cedula = (tblResultado.Rows[i]["Cedula"].ToString());
                objNecesidadCliente.idNecesidadCliente = int.Parse(tblResultado.Rows[i]["idNecesidadCliente"].ToString());
    



}
}
