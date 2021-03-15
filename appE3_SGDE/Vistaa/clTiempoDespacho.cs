using System;

public class TiempoDespacho
{
	public TiempoDespacho()
	{

     public int idTiempoDespacho { get; set; }
    public string Ciudad { get; set; }
    public string FechaDeSolicitud { get; set; }
    public string FechaDeDespacho { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public string Email { get; set; }
    public int idTiempoDespacho { get; set; }

    clConexion objConexion;
    public List<clTiempoDespacho> mtdRegistrar()
    {
        string consulta = ("select * from TiempoDespacho");

        DataTable tblResultado = new DataTable();
        objConexion = new clConexion();
        tblResultado = objConexion.mtdDesconectado(consulta);

        List<clTiempoDespacho> listTiempoDespacho = new List<clTiempoDespacho>();

        for (int i = 0; i < tblResultado.Rows.Count; i++)
        {
            clTiempoDespacho objTiempoDespacho = new clTiempoDespacho();
            objTiempoDespacho.idTiempoDespacho = int.Parse(tblResultado.Rows[i]["idTiempoDespacho"].ToString());
            objTiempoDespacho.Ciudad = tblResultado.Rows[i]["Ciudad"].ToString();
            objTiempoDespacho.FechaDeSolicitud = DateTime.Rows[i]["FechaDeSolicitud"].ToString();
            objTiempoDespacho.FechaDeDespacho = DateTime.Rows[i]["FechaDeDespacho"].ToString();
            objTiempoDespacho.Nombres = tblResultado.Parse(tblResultado.Rows[i]["TiempoDespacho"].ToString());
            objTiempoDespacho.Apellidos = tblResultado.Rows[i]["Apellidos"].ToString();
            objTiempoDespacho.Email = tblResultado.Rows[i][" Email"].ToString();
            objTiempoDespacho.idTiempoDespacho = int.Parse(tblResultado.Rows[i]["idTiempoDespacho"].ToString());


            listTiempoDespacho.Add(objTiempoDespacho);




        }

        return listTiempoDespacho;
    }

    public int mtdRegistrar()
   
    {
        string fecha = Convert.ToDateTime(FechaDeSolicitud).ToString("yyyy-MM-dd");
        string fecha = Convert.ToDateTime(FechaDeDespacho).ToString("yyyy-MM-dd");
        string consulta = "insert into TiempoDespacho (Ciudad,FechaDeSolicitud,FechaDeDespacho,TiempoDespacho,Apellidos,Email,idTiempoDespacho) values ('" + Ciudad + "','" + FechaDeSolicitud + "','" + FechaDeDespacho + "','" + Nombres + "','" + Apellidos + "','" + Email + "','" + idTiempoDespacho + "','" )";
        clConexion objConexion = new clConexion();
        int resultado = objConexion.mtdConectado(consulta);
        return resultado;

