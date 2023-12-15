Imports System.Data.SqlClient

Public Class ModificarPersona

    Private Sub BuscarPersona(rutABuscar As String)
        Try
            ' Abrir la conexión a la base de datos
            abrirConexionBBDD()

            ' Modificar la consulta para buscar por RUT
            Dim query As String = "SELECT * FROM Persona WHERE rut = @rut"

            ' Crear un nuevo comando SQL con la consulta y la conexión
            Using cmd As New SqlCommand(query, conexion)
                ' Configurar parámetro
                cmd.Parameters.AddWithValue("@rut", rutABuscar)

                ' Ejecutar la consulta y obtener un lector de datos
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    ' Verificar si se encontró un registro
                    If reader.Read() Then
                        ' Llenar los campos con los datos obtenidos
                        TextBox1_rut.Text = reader("rut").ToString()
                        TextBox2_nombre.Text = reader("nombreCompleto").ToString()
                        TextBox3_apellido1.Text = reader("apellidoPaterno").ToString()
                        TextBox4_apellido2.Text = reader("apellidoMaterno").ToString()
                        DateTimePicker1_fechaNacimiento.Text = reader("fechaNacimiento").ToString()
                        TextBox14_telefonoFijo.Text = reader("telefonoFijo").ToString()
                        TextBox15_telefonoMovil.Text = reader("telefonoMovil").ToString()
                        TextBox4_correoPersonal.Text = reader("correoPersonal").ToString()
                        TextBox5_correoLaboral.Text = reader("correoLaboral").ToString()
                        ComboBox_gruposanguineo.Text = reader("grupoSanguineo").ToString()
                        Label_direccionPersonal.Text = reader("direccionPersonal").ToString()
                        Label_direccionComercial.Text = reader("direccionComercial").ToString()
                        Label_direccionFacturacion.Text = reader("direccionFacturacion").ToString()
                    Else
                        ' Si no se encontró un registro, puedes mostrar un mensaje indicando que no se encontró.
                        MessageBox.Show("No se encontró ninguna persona con el RUT proporcionado.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Mostrar un mensaje de error si ocurre alguna excepción
            MessageBox.Show("Error al buscar en la base de datos. Detalles del error: " & ex.Message)
        Finally
            ' Cerrar la conexión a la base de datos
            cerrarConexionBBDD()
        End Try
    End Sub

    Sub ModificarPersona(rut As String, nombre As String, apellidoPaterno As String, apellidoMaterno As String, fechaNacimiento As Date, grupoSanguineo As String, regionPersonal As String, comunaPersonal As String, callePersonal As String, regionComercial As String, comunaComercial As String, calleComercial As String, regionFacturacion As String, comunaFacturacion As String, calleFacturacion As String, telefonoFijo As String, telefonoMovil As String, correoPersonal As String, correoLaboral As String)
        Try
            ' Abrir la conexión a la base de datos
            abrirConexionBBDD()

            ' Modificar la consulta para realizar un UPDATE en lugar de un INSERT
            Dim query As String = "UPDATE Persona SET nombreCompleto = @nombre, apellidoPaterno = @apellidoPaterno, apellidoMaterno = @apellidoMaterno, fechaNacimiento = @fechaNacimiento, grupoSanguineo = @grupoSanguineo, direccionPersonal = @direccionPersonal, direccionComercial = @direccionComercial, direccionFacturacion = @direccionFacturacion, telefonoFijo = @telefonoFijo, telefonoMovil = @telefonoMovil, correoPersonal = @correoPersonal, correoLaboral = @correoLaboral WHERE rut = @rut"

            ' Crear un nuevo comando SQL con la consulta y la conexión
            Using cmd As New SqlCommand(query, conexion)
                ' Configurar parámetros
                cmd.Parameters.AddWithValue("@rut", rut)
                cmd.Parameters.AddWithValue("@nombre", nombre)
                cmd.Parameters.AddWithValue("@apellidoPaterno", apellidoPaterno)
                cmd.Parameters.AddWithValue("@apellidoMaterno", apellidoMaterno)
                cmd.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento)
                cmd.Parameters.AddWithValue("@grupoSanguineo", grupoSanguineo)

                ' Configurar dirección personal
                Dim direccionPersonal As String = $"{regionPersonal}, {comunaPersonal}, {callePersonal}"
                cmd.Parameters.AddWithValue("@direccionPersonal", direccionPersonal)

                ' Configurar dirección comercial
                Dim direccionComercial As String = $"{regionComercial}, {comunaComercial}, {calleComercial}"
                cmd.Parameters.AddWithValue("@direccionComercial", direccionComercial)

                ' Configurar dirección de facturación
                Dim direccionFacturacion As String = $"{regionFacturacion}, {comunaFacturacion}, {calleFacturacion}"
                cmd.Parameters.AddWithValue("@direccionFacturacion", direccionFacturacion)

                cmd.Parameters.AddWithValue("@telefonoFijo", telefonoFijo)
                cmd.Parameters.AddWithValue("@telefonoMovil", telefonoMovil)
                cmd.Parameters.AddWithValue("@correoPersonal", correoPersonal)
                cmd.Parameters.AddWithValue("@correoLaboral", correoLaboral)

                ' Ejecutar la consulta
                cmd.ExecuteNonQuery()
            End Using

            ' Cerrar la conexión a la base de datos
            cerrarConexionBBDD()
        Catch ex As Exception
            ' Mostrar un mensaje de error si ocurre alguna excepción
            MessageBox.Show("Error al modificar en la base de datos. Detalles del error: " & ex.Message)
        End Try
    End Sub


    Private Sub ComboBox1_regionPersonal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1_regionPersonal.SelectedIndexChanged
        ' Limpiar los elementos anteriores
        ComboBox2_comunaPersonal.Items.Clear()

        If ComboBox1_regionPersonal.Text = "Arica y Parinacota" Then
            ComboBox2_comunaPersonal.Enabled = True
            ComboBox2_comunaPersonal.Items.AddRange({"Arica", "Putre", "General Lagos", "Camarones"})
        End If

        If ComboBox1_regionPersonal.Text = "Tarapacá" Then
            ComboBox2_comunaPersonal.Enabled = True
            ComboBox2_comunaPersonal.Items.AddRange({"Huara", "Camiña", "Colchane", "Pica", "Pozo Almonte", "Alto Hospicio", "Iquique"})
        End If

        If ComboBox1_regionPersonal.Text = "Antofagasta" Then
            ComboBox2_comunaPersonal.Enabled = True
            ComboBox2_comunaPersonal.Items.AddRange({"Antofagasta", "Mejillones", "Sierra Gorda", "Taltal", "Calama", "Ollagüe", "San Pedro de Atacama", "María Elena", "Tocopilla"})
        End If

        If ComboBox1_regionPersonal.Text = "Atacama" Then
            ComboBox2_comunaPersonal.Enabled = True
            ComboBox2_comunaPersonal.Items.AddRange({"Chañaral", "Diego de Almagro", "Caldera", "Copiapó", "Tierra Amarilla", "Alto del Carmen", "Freirina", "Huasco", "Vallenar"})
        End If

        If ComboBox1_regionPersonal.Text = "Coquimbo" Then
            ComboBox2_comunaPersonal.Enabled = True
            ComboBox2_comunaPersonal.Items.AddRange({"Canela", "Illapel", "Los Vilos", "Salamanca", "Andacollo", "Coquimbo", "La Higuera", "La Serena", "Paihuano", "Vicuña", "Combarbalá", "Monte Patria", "Ovalle", "Punitaqui y Río HurtadoCanela", "Illapel", "Los Vilos", "Salamanca", "Andacollo", "Coquimbo", "La Higuera", "La Serena", "Paihuano", "Vicuña", "Combarbalá", "Monte Patria", "Ovalle", "Punitaqui", "Río Hurtado"})
        End If

        If ComboBox1_regionPersonal.Text = "Valparaíso" Then
            ComboBox2_comunaPersonal.Enabled = True
            ComboBox2_comunaPersonal.Items.AddRange({"Hanga Roa", "Calle Larga", "Los Andes", "Rinconada", "San Esteban", "Cabildo", "La Ligua", "Papudo", "Petorca", "Zapallar", "Hijuelas", "La Calera", "La Cruz", "Nogales", "Quillota", "Algarrobo", "Cartagena", "El Quisco", "El Tabo", "San Antonio", "Santo Domingo", "Catemu", "Llay-Llay", "Panquehue", "Putaendo", "San Felipe", "Santa María", "Casablanca", "Concón", "Juan Fernández", "Puchuncaví", "Quintero", "Valparaíso", "Viña del Mar", "Limache", "Olmué", "Quilpué", "Villa Alemana"})
        End If

        If ComboBox1_regionPersonal.Text = "Metropolitana de Santiago" Then
            ComboBox2_comunaPersonal.Enabled = True
            ComboBox2_comunaPersonal.Items.AddRange({"Colina", "Lampa", "Til Til", "Pirque", "Puente Alto", "San José de Maipo", "Buin", "Calera de Tango", "Paine", "San Bernardo", "Alhué", "Curacaví", "María Pinto", "Melipilla", "San Pedro", "Cerrillos", "Cerro Navia, Conchalí", "El Bosque", "Estación Central", "Huechuraba", "Independencia", "La Cisterna", "La Granja", "La Florida", "La Pintana", "La Reina", "Las Condes", "Lo Barnechea", "Lo Espejo", "Lo Prado", "Macul", "Maipú", "Ñuñoa", "Pedro Aguirre Cerda", "Peñalolén", "Providencia", "Pudahuel", "Quilicura", "Quinta Normal", "Recoleta", "Renca", "San Miguel", "San Joaquín", "San Ramón", "Santiago", "Vitacura", "El Monte", "Isla de Maipo", "Padre Hurtado", "Peñaflor", "Talagante"})
        End If

        If ComboBox1_regionPersonal.Text = "Libertador General Bernardo O'Higgins" Then
            ComboBox2_comunaPersonal.Enabled = True
            ComboBox2_comunaPersonal.Items.AddRange({"Codegua", "Coinco", "Coltauco", "Doñihue", "Graneros", "Las Cabras", "Machalí", "Malloa", "Mostazal", "Olivar", "Peumo", "Pichidegua", "Quinta de Tilcoco", "Rancagua", "Rengo", "Requínoa", "San Vicente de Tagua Tagua", "La Estrella", "Litueche", "Marchigüe", "Navidad", "Paredones", "Pichilemu", "Chépica", "Chimbarongo", "Lolol", "Nancagua", "Palmilla", "Peralillo", "Placilla", "Pumanque", "San Fernando", "Santa Cruz"})
        End If

        If ComboBox1_regionPersonal.Text = "Maule" Then
            ComboBox2_comunaPersonal.Enabled = True
            ComboBox2_comunaPersonal.Items.AddRange({"Cauquenes", "Chanco", "Pelluhue", "Curicó", "Hualañé", "Licantén", "Molina", "Rauco", "Romeral", "Sagrada Familia", "Teno", "Vichuquén", "Colbún", "Linares", "Longaví", "Parral", "Retiro", "San Javier de Loncomilla", "Villa Alegre", "Yerbas Buenas", "Constitución", "Curepto", "Empedrado", "Maule", "Pelarco", "Pencahue", "Río Claro", "San Clemente", "San Rafael", "Talca"})
        End If

        If ComboBox1_regionPersonal.Text = "Ñuble" Then
            ComboBox2_comunaPersonal.Enabled = True
            ComboBox2_comunaPersonal.Items.AddRange({"Cobquecura", "Coelemu", "Ninhue", "Portezuelo", "Quirihue", "Ránquil", "Trehuaco", "Bulnes", "Chillán Viejo", "Chillán", "El Carmen", "Pemuco", "Pinto", "Quillón", "San Ignacio", "Yungay", "Coihueco", "Ñiquén", "San Carlos", "San Fabián", "San Nicolás"})
        End If

        If ComboBox1_regionPersonal.Text = "Biobío" Then
            ComboBox2_comunaPersonal.Enabled = True
            ComboBox2_comunaPersonal.Items.AddRange({"Arauco", "Cañete", "Contulmo", "Curanilahue", "Lebu", "Los Álamos", "Tirúa", "Alto Biobío", "Antuco", "Cabrero", "Laja", "Los Ángeles", "Mulchén", "Nacimiento", "Negrete", "Quilaco", "Quilleco", "San Rosendo", "Santa Bárbara", "Tucapel", "Yumbel", "Chiguayante", "Concepción", "Coronel", "Florida", "Hualpén", "Hualqui", "Lota", "Penco", "San Pedro de la Paz", "Santa Juana", "Talcahuano", "Tomé"})
        End If

        If ComboBox1_regionPersonal.Text = "Araucanía" Then
            ComboBox2_comunaPersonal.Enabled = True
            ComboBox2_comunaPersonal.Items.AddRange({"Carahue", "Cholchol", "Cunco", "Curarrehue", "Freire", "Galvarino", "Gorbea", "Lautaro", "Loncoche", "Melipeuco", "Nueva Imperial", "Padre Las Casas", "Perquenco", "Pitrufquén", "Pucón", "Saavedra", "Temuco", "Teodoro Schmidt", "Toltén", "Vilcún", "Villarrica", "Angol", "Collipulli", "Curacautín", "Ercilla", "Lonquimay", "Los Sauces", "Lumaco", "Purén", "Renaico", "Traiguén", "Victoria"})
        End If

        If ComboBox1_regionPersonal.Text = "Los Ríos" Then
            ComboBox2_comunaPersonal.Enabled = True
            ComboBox2_comunaPersonal.Items.AddRange({"Panguipulli", "Futrono", "Río Bueno", "Lago Ranco", "La Unión", "Corral", "Paillaco", "Valdivia", "Máfil", "Lanco", "Mariquina", "Los Lagos"})
        End If

        If ComboBox1_regionPersonal.Text = "Los Lagos" Then
            ComboBox2_comunaPersonal.Enabled = True
            ComboBox2_comunaPersonal.Items.AddRange({"Ancud", "Castro", "Chonchi", "Curaco de Vélez", "Dalcahue", "Puqueldón", "Queilén", "Quemchi", "Quellón", "Quinchao", "Calbuco", "Cochamó", "Fresia", "Frutillar", "Llanquihue", "Los Muermos", "Maullín", "Puerto Montt", "Puerto Varas", "Osorno", "Puerto Octay", "Purranque", "Puyehue", "Río Negro", "San Juan de la Costa", "San Pablo", "Chaitén", "Futaleufú", "Hualaihué", "Palena"})
        End If

        If ComboBox1_regionPersonal.Text = "Aysén del General Carlos Ibáñez del Campo" Then
            ComboBox2_comunaPersonal.Enabled = True
            ComboBox2_comunaPersonal.Items.AddRange({"Guaitecas", "Cisnes", "Lago Verde", "Coyhaique", "Aysén", "Río Ibáñez", "Chile Chico", "Cochrane", "O'Higgins", "Tortel"})
        End If

        If ComboBox1_regionPersonal.Text = "Magallanes y de la Antártica Chilena" Then
            ComboBox2_comunaPersonal.Enabled = True
            ComboBox2_comunaPersonal.Items.AddRange({"Antártica", "Cabo de Hornos", "Laguna Blanca", "Punta Arenas", "Río Verde", "San Gregorio", "Porvenir", "Primavera", "Timaukel", "Natales", "Torres del Paine"})
        End If
    End Sub

    Private Sub ComboBox4_regionComercial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4_regionComercial.SelectedIndexChanged
        ' Limpiar los elementos anteriores
        ComboBox3_comunaComercial.Items.Clear()


        If ComboBox4_regionComercial.Text = "Arica y Parinacota" Then
            ComboBox3_comunaComercial.Enabled = True
            ComboBox3_comunaComercial.Items.AddRange({"Arica", "Putre", "General Lagos", "Camarones"})
        End If

        If ComboBox4_regionComercial.Text = "Tarapacá" Then
            ComboBox3_comunaComercial.Enabled = True
            ComboBox3_comunaComercial.Items.AddRange({"Huara", "Camiña", "Colchane", "Pica", "Pozo Almonte", "Alto Hospicio", "Iquique"})
        End If

        If ComboBox4_regionComercial.Text = "Antofagasta" Then
            ComboBox3_comunaComercial.Enabled = True
            ComboBox3_comunaComercial.Items.AddRange({"Antofagasta", "Mejillones", "Sierra Gorda", "Taltal", "Calama", "Ollagüe", "San Pedro de Atacama", "María Elena", "Tocopilla"})
        End If

        If ComboBox4_regionComercial.Text = "Atacama" Then
            ComboBox3_comunaComercial.Enabled = True
            ComboBox3_comunaComercial.Items.AddRange({"Chañaral", "Diego de Almagro", "Caldera", "Copiapó", "Tierra Amarilla", "Alto del Carmen", "Freirina", "Huasco", "Vallenar"})
        End If

        If ComboBox4_regionComercial.Text = "Coquimbo" Then
            ComboBox3_comunaComercial.Enabled = True
            ComboBox3_comunaComercial.Items.AddRange({"Canela", "Illapel", "Los Vilos", "Salamanca", "Andacollo", "Coquimbo", "La Higuera", "La Serena", "Paihuano", "Vicuña", "Combarbalá", "Monte Patria", "Ovalle", "Punitaqui y Río HurtadoCanela", "Illapel", "Los Vilos", "Salamanca", "Andacollo", "Coquimbo", "La Higuera", "La Serena", "Paihuano", "Vicuña", "Combarbalá", "Monte Patria", "Ovalle", "Punitaqui", "Río Hurtado"})
        End If

        If ComboBox4_regionComercial.Text = "Valparaíso" Then
            ComboBox3_comunaComercial.Enabled = True
            ComboBox3_comunaComercial.Items.AddRange({"Hanga Roa", "Calle Larga", "Los Andes", "Rinconada", "San Esteban", "Cabildo", "La Ligua", "Papudo", "Petorca", "Zapallar", "Hijuelas", "La Calera", "La Cruz", "Nogales", "Quillota", "Algarrobo", "Cartagena", "El Quisco", "El Tabo", "San Antonio", "Santo Domingo", "Catemu", "Llay-Llay", "Panquehue", "Putaendo", "San Felipe", "Santa María", "Casablanca", "Concón", "Juan Fernández", "Puchuncaví", "Quintero", "Valparaíso", "Viña del Mar", "Limache", "Olmué", "Quilpué", "Villa Alemana"})
        End If

        If ComboBox4_regionComercial.Text = "Metropolitana de Santiago" Then
            ComboBox3_comunaComercial.Enabled = True
            ComboBox3_comunaComercial.Items.AddRange({"Colina", "Lampa", "Til Til", "Pirque", "Puente Alto", "San José de Maipo", "Buin", "Calera de Tango", "Paine", "San Bernardo", "Alhué", "Curacaví", "María Pinto", "Melipilla", "San Pedro", "Cerrillos", "Cerro Navia, Conchalí", "El Bosque", "Estación Central", "Huechuraba", "Independencia", "La Cisterna", "La Granja", "La Florida", "La Pintana", "La Reina", "Las Condes", "Lo Barnechea", "Lo Espejo", "Lo Prado", "Macul", "Maipú", "Ñuñoa", "Pedro Aguirre Cerda", "Peñalolén", "Providencia", "Pudahuel", "Quilicura", "Quinta Normal", "Recoleta", "Renca", "San Miguel", "San Joaquín", "San Ramón", "Santiago", "Vitacura", "El Monte", "Isla de Maipo", "Padre Hurtado", "Peñaflor", "Talagante"})
        End If

        If ComboBox4_regionComercial.Text = "Libertador General Bernardo O'Higgins" Then
            ComboBox3_comunaComercial.Enabled = True
            ComboBox3_comunaComercial.Items.AddRange({"Codegua", "Coinco", "Coltauco", "Doñihue", "Graneros", "Las Cabras", "Machalí", "Malloa", "Mostazal", "Olivar", "Peumo", "Pichidegua", "Quinta de Tilcoco", "Rancagua", "Rengo", "Requínoa", "San Vicente de Tagua Tagua", "La Estrella", "Litueche", "Marchigüe", "Navidad", "Paredones", "Pichilemu", "Chépica", "Chimbarongo", "Lolol", "Nancagua", "Palmilla", "Peralillo", "Placilla", "Pumanque", "San Fernando", "Santa Cruz"})
        End If

        If ComboBox4_regionComercial.Text = "Maule" Then
            ComboBox3_comunaComercial.Enabled = True
            ComboBox3_comunaComercial.Items.AddRange({"Cauquenes", "Chanco", "Pelluhue", "Curicó", "Hualañé", "Licantén", "Molina", "Rauco", "Romeral", "Sagrada Familia", "Teno", "Vichuquén", "Colbún", "Linares", "Longaví", "Parral", "Retiro", "San Javier de Loncomilla", "Villa Alegre", "Yerbas Buenas", "Constitución", "Curepto", "Empedrado", "Maule", "Pelarco", "Pencahue", "Río Claro", "San Clemente", "San Rafael", "Talca"})
        End If

        If ComboBox4_regionComercial.Text = "Ñuble" Then
            ComboBox3_comunaComercial.Enabled = True
            ComboBox3_comunaComercial.Items.AddRange({"Cobquecura", "Coelemu", "Ninhue", "Portezuelo", "Quirihue", "Ránquil", "Trehuaco", "Bulnes", "Chillán Viejo", "Chillán", "El Carmen", "Pemuco", "Pinto", "Quillón", "San Ignacio", "Yungay", "Coihueco", "Ñiquén", "San Carlos", "San Fabián", "San Nicolás"})
        End If

        If ComboBox4_regionComercial.Text = "Biobío" Then
            ComboBox3_comunaComercial.Enabled = True
            ComboBox3_comunaComercial.Items.AddRange({"Arauco", "Cañete", "Contulmo", "Curanilahue", "Lebu", "Los Álamos", "Tirúa", "Alto Biobío", "Antuco", "Cabrero", "Laja", "Los Ángeles", "Mulchén", "Nacimiento", "Negrete", "Quilaco", "Quilleco", "San Rosendo", "Santa Bárbara", "Tucapel", "Yumbel", "Chiguayante", "Concepción", "Coronel", "Florida", "Hualpén", "Hualqui", "Lota", "Penco", "San Pedro de la Paz", "Santa Juana", "Talcahuano", "Tomé"})
        End If

        If ComboBox4_regionComercial.Text = "Araucanía" Then
            ComboBox3_comunaComercial.Enabled = True
            ComboBox3_comunaComercial.Items.AddRange({"Carahue", "Cholchol", "Cunco", "Curarrehue", "Freire", "Galvarino", "Gorbea", "Lautaro", "Loncoche", "Melipeuco", "Nueva Imperial", "Padre Las Casas", "Perquenco", "Pitrufquén", "Pucón", "Saavedra", "Temuco", "Teodoro Schmidt", "Toltén", "Vilcún", "Villarrica", "Angol", "Collipulli", "Curacautín", "Ercilla", "Lonquimay", "Los Sauces", "Lumaco", "Purén", "Renaico", "Traiguén", "Victoria"})
        End If

        If ComboBox4_regionComercial.Text = "Los Ríos" Then
            ComboBox3_comunaComercial.Enabled = True
            ComboBox3_comunaComercial.Items.AddRange({"Panguipulli", "Futrono", "Río Bueno", "Lago Ranco", "La Unión", "Corral", "Paillaco", "Valdivia", "Máfil", "Lanco", "Mariquina", "Los Lagos"})
        End If

        If ComboBox4_regionComercial.Text = "Los Lagos" Then
            ComboBox3_comunaComercial.Enabled = True
            ComboBox3_comunaComercial.Items.AddRange({"Ancud", "Castro", "Chonchi", "Curaco de Vélez", "Dalcahue", "Puqueldón", "Queilén", "Quemchi", "Quellón", "Quinchao", "Calbuco", "Cochamó", "Fresia", "Frutillar", "Llanquihue", "Los Muermos", "Maullín", "Puerto Montt", "Puerto Varas", "Osorno", "Puerto Octay", "Purranque", "Puyehue", "Río Negro", "San Juan de la Costa", "San Pablo", "Chaitén", "Futaleufú", "Hualaihué", "Palena"})
        End If

        If ComboBox4_regionComercial.Text = "Aysén del General Carlos Ibáñez del Campo" Then
            ComboBox3_comunaComercial.Enabled = True
            ComboBox3_comunaComercial.Items.AddRange({"Guaitecas", "Cisnes", "Lago Verde", "Coyhaique", "Aysén", "Río Ibáñez", "Chile Chico", "Cochrane", "O'Higgins", "Tortel"})
        End If

        If ComboBox4_regionComercial.Text = "Magallanes y de la Antártica Chilena" Then
            ComboBox3_comunaComercial.Enabled = True
            ComboBox3_comunaComercial.Items.AddRange({"Antártica", "Cabo de Hornos", "Laguna Blanca", "Punta Arenas", "Río Verde", "San Gregorio", "Porvenir", "Primavera", "Timaukel", "Natales", "Torres del Paine"})
        End If
    End Sub

    Private Sub ComboBox6_regionFacturacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6_regionFacturacion.SelectedIndexChanged
        ' Limpiar los elementos anteriores
        ComboBox5_comunaFacturacion.Items.Clear()

        If ComboBox6_regionFacturacion.Text = "Arica y Parinacota" Then
            ComboBox5_comunaFacturacion.Enabled = True
            ComboBox5_comunaFacturacion.Items.AddRange({"Arica", "Putre", "General Lagos", "Camarones"})
        End If

        If ComboBox6_regionFacturacion.Text = "Tarapacá" Then
            ComboBox5_comunaFacturacion.Enabled = True
            ComboBox5_comunaFacturacion.Items.AddRange({"Huara", "Camiña", "Colchane", "Pica", "Pozo Almonte", "Alto Hospicio", "Iquique"})
        End If

        If ComboBox6_regionFacturacion.Text = "Antofagasta" Then
            ComboBox5_comunaFacturacion.Enabled = True
            ComboBox5_comunaFacturacion.Items.AddRange({"Antofagasta", "Mejillones", "Sierra Gorda", "Taltal", "Calama", "Ollagüe", "San Pedro de Atacama", "María Elena", "Tocopilla"})
        End If

        If ComboBox6_regionFacturacion.Text = "Atacama" Then
            ComboBox5_comunaFacturacion.Enabled = True
            ComboBox5_comunaFacturacion.Items.AddRange({"Chañaral", "Diego de Almagro", "Caldera", "Copiapó", "Tierra Amarilla", "Alto del Carmen", "Freirina", "Huasco", "Vallenar"})
        End If

        If ComboBox6_regionFacturacion.Text = "Coquimbo" Then
            ComboBox5_comunaFacturacion.Enabled = True
            ComboBox5_comunaFacturacion.Items.AddRange({"Canela", "Illapel", "Los Vilos", "Salamanca", "Andacollo", "Coquimbo", "La Higuera", "La Serena", "Paihuano", "Vicuña", "Combarbalá", "Monte Patria", "Ovalle", "Punitaqui y Río HurtadoCanela", "Illapel", "Los Vilos", "Salamanca", "Andacollo", "Coquimbo", "La Higuera", "La Serena", "Paihuano", "Vicuña", "Combarbalá", "Monte Patria", "Ovalle", "Punitaqui", "Río Hurtado"})
        End If

        If ComboBox6_regionFacturacion.Text = "Valparaíso" Then
            ComboBox5_comunaFacturacion.Enabled = True
            ComboBox5_comunaFacturacion.Items.AddRange({"Hanga Roa", "Calle Larga", "Los Andes", "Rinconada", "San Esteban", "Cabildo", "La Ligua", "Papudo", "Petorca", "Zapallar", "Hijuelas", "La Calera", "La Cruz", "Nogales", "Quillota", "Algarrobo", "Cartagena", "El Quisco", "El Tabo", "San Antonio", "Santo Domingo", "Catemu", "Llay-Llay", "Panquehue", "Putaendo", "San Felipe", "Santa María", "Casablanca", "Concón", "Juan Fernández", "Puchuncaví", "Quintero", "Valparaíso", "Viña del Mar", "Limache", "Olmué", "Quilpué", "Villa Alemana"})
        End If

        If ComboBox6_regionFacturacion.Text = "Metropolitana de Santiago" Then
            ComboBox5_comunaFacturacion.Enabled = True
            ComboBox5_comunaFacturacion.Items.AddRange({"Colina", "Lampa", "Til Til", "Pirque", "Puente Alto", "San José de Maipo", "Buin", "Calera de Tango", "Paine", "San Bernardo", "Alhué", "Curacaví", "María Pinto", "Melipilla", "San Pedro", "Cerrillos", "Cerro Navia, Conchalí", "El Bosque", "Estación Central", "Huechuraba", "Independencia", "La Cisterna", "La Granja", "La Florida", "La Pintana", "La Reina", "Las Condes", "Lo Barnechea", "Lo Espejo", "Lo Prado", "Macul", "Maipú", "Ñuñoa", "Pedro Aguirre Cerda", "Peñalolén", "Providencia", "Pudahuel", "Quilicura", "Quinta Normal", "Recoleta", "Renca", "San Miguel", "San Joaquín", "San Ramón", "Santiago", "Vitacura", "El Monte", "Isla de Maipo", "Padre Hurtado", "Peñaflor", "Talagante"})
        End If

        If ComboBox6_regionFacturacion.Text = "Libertador General Bernardo O'Higgins" Then
            ComboBox5_comunaFacturacion.Enabled = True
            ComboBox5_comunaFacturacion.Items.AddRange({"Codegua", "Coinco", "Coltauco", "Doñihue", "Graneros", "Las Cabras", "Machalí", "Malloa", "Mostazal", "Olivar", "Peumo", "Pichidegua", "Quinta de Tilcoco", "Rancagua", "Rengo", "Requínoa", "San Vicente de Tagua Tagua", "La Estrella", "Litueche", "Marchigüe", "Navidad", "Paredones", "Pichilemu", "Chépica", "Chimbarongo", "Lolol", "Nancagua", "Palmilla", "Peralillo", "Placilla", "Pumanque", "San Fernando", "Santa Cruz"})
        End If

        If ComboBox6_regionFacturacion.Text = "Maule" Then
            ComboBox5_comunaFacturacion.Enabled = True
            ComboBox5_comunaFacturacion.Items.AddRange({"Cauquenes", "Chanco", "Pelluhue", "Curicó", "Hualañé", "Licantén", "Molina", "Rauco", "Romeral", "Sagrada Familia", "Teno", "Vichuquén", "Colbún", "Linares", "Longaví", "Parral", "Retiro", "San Javier de Loncomilla", "Villa Alegre", "Yerbas Buenas", "Constitución", "Curepto", "Empedrado", "Maule", "Pelarco", "Pencahue", "Río Claro", "San Clemente", "San Rafael", "Talca"})
        End If

        If ComboBox6_regionFacturacion.Text = "Ñuble" Then
            ComboBox5_comunaFacturacion.Enabled = True
            ComboBox5_comunaFacturacion.Items.AddRange({"Cobquecura", "Coelemu", "Ninhue", "Portezuelo", "Quirihue", "Ránquil", "Trehuaco", "Bulnes", "Chillán Viejo", "Chillán", "El Carmen", "Pemuco", "Pinto", "Quillón", "San Ignacio", "Yungay", "Coihueco", "Ñiquén", "San Carlos", "San Fabián", "San Nicolás"})
        End If

        If ComboBox6_regionFacturacion.Text = "Biobío" Then
            ComboBox5_comunaFacturacion.Enabled = True
            ComboBox5_comunaFacturacion.Items.AddRange({"Arauco", "Cañete", "Contulmo", "Curanilahue", "Lebu", "Los Álamos", "Tirúa", "Alto Biobío", "Antuco", "Cabrero", "Laja", "Los Ángeles", "Mulchén", "Nacimiento", "Negrete", "Quilaco", "Quilleco", "San Rosendo", "Santa Bárbara", "Tucapel", "Yumbel", "Chiguayante", "Concepción", "Coronel", "Florida", "Hualpén", "Hualqui", "Lota", "Penco", "San Pedro de la Paz", "Santa Juana", "Talcahuano", "Tomé"})
        End If

        If ComboBox6_regionFacturacion.Text = "Araucanía" Then
            ComboBox5_comunaFacturacion.Enabled = True
            ComboBox5_comunaFacturacion.Items.AddRange({"Carahue", "Cholchol", "Cunco", "Curarrehue", "Freire", "Galvarino", "Gorbea", "Lautaro", "Loncoche", "Melipeuco", "Nueva Imperial", "Padre Las Casas", "Perquenco", "Pitrufquén", "Pucón", "Saavedra", "Temuco", "Teodoro Schmidt", "Toltén", "Vilcún", "Villarrica", "Angol", "Collipulli", "Curacautín", "Ercilla", "Lonquimay", "Los Sauces", "Lumaco", "Purén", "Renaico", "Traiguén", "Victoria"})
        End If

        If ComboBox6_regionFacturacion.Text = "Los Ríos" Then
            ComboBox5_comunaFacturacion.Enabled = True
            ComboBox5_comunaFacturacion.Items.AddRange({"Panguipulli", "Futrono", "Río Bueno", "Lago Ranco", "La Unión", "Corral", "Paillaco", "Valdivia", "Máfil", "Lanco", "Mariquina", "Los Lagos"})
        End If

        If ComboBox6_regionFacturacion.Text = "Los Lagos" Then
            ComboBox5_comunaFacturacion.Enabled = True
            ComboBox5_comunaFacturacion.Items.AddRange({"Ancud", "Castro", "Chonchi", "Curaco de Vélez", "Dalcahue", "Puqueldón", "Queilén", "Quemchi", "Quellón", "Quinchao", "Calbuco", "Cochamó", "Fresia", "Frutillar", "Llanquihue", "Los Muermos", "Maullín", "Puerto Montt", "Puerto Varas", "Osorno", "Puerto Octay", "Purranque", "Puyehue", "Río Negro", "San Juan de la Costa", "San Pablo", "Chaitén", "Futaleufú", "Hualaihué", "Palena"})
        End If

        If ComboBox6_regionFacturacion.Text = "Aysén del General Carlos Ibáñez del Campo" Then
            ComboBox5_comunaFacturacion.Enabled = True
            ComboBox5_comunaFacturacion.Items.AddRange({"Guaitecas", "Cisnes", "Lago Verde", "Coyhaique", "Aysén", "Río Ibáñez", "Chile Chico", "Cochrane", "O'Higgins", "Tortel"})
        End If

        If ComboBox6_regionFacturacion.Text = "Magallanes y de la Antártica Chilena" Then
            ComboBox5_comunaFacturacion.Enabled = True
            ComboBox5_comunaFacturacion.Items.AddRange({"Antártica", "Cabo de Hornos", "Laguna Blanca", "Punta Arenas", "Río Verde", "San Gregorio", "Porvenir", "Primavera", "Timaukel", "Natales", "Torres del Paine"})
        End If
    End Sub

    Private Sub ComboBox2_comunaPersonal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2_comunaPersonal.SelectedIndexChanged
        TextBox12_callePersonal.Enabled = True
    End Sub

    Private Sub ComboBox3_comunaComercial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3_comunaComercial.SelectedIndexChanged
        TextBox9_calleComercial.Enabled = True
    End Sub

    Private Sub ComboBox5_comunaFacturacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5_comunaFacturacion.SelectedIndexChanged
        TextBox10_calleFacturacion.Enabled = True
    End Sub

    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click
        ' Obtener el RUT a buscar desde el TextBox
        Dim rutABuscar As String = buscarRut.Text

        ' Llamar a la función que busca en la base de datos y llena los campos
        BuscarPersona(rutABuscar)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Validar que los campos obligatorios no estén vacíos
        If TextBox1_rut.Text.Trim() = "" Or TextBox2_nombre.Text.Trim() = "" Or TextBox3_apellido1.Text.Trim() = "" Or DateTimePicker1_fechaNacimiento.Text.Trim() = "" Then
            MsgBox("Faltan datos obligatorios", MsgBoxStyle.Exclamation, "Campo Vacío")
        Else
            ' Llamar al método para insertar datos en la base de datos
            ModificarPersona(
                    TextBox1_rut.Text.Trim(),
                    TextBox2_nombre.Text.Trim(),
                    TextBox3_apellido1.Text.Trim(),
                    TextBox4_apellido2.Text.Trim(),
                    DateTimePicker1_fechaNacimiento.Value,
                    ComboBox_gruposanguineo.Text.Trim(),
                    ComboBox1_regionPersonal.Text.Trim(),
                    ComboBox2_comunaPersonal.Text.Trim(),
                    TextBox12_callePersonal.Text.Trim(),
                    ComboBox4_regionComercial.Text.Trim(),
                    ComboBox3_comunaComercial.Text.Trim(),
                    TextBox9_calleComercial.Text.Trim(),
                    ComboBox6_regionFacturacion.Text.Trim(),
                    ComboBox5_comunaFacturacion.Text.Trim(),
                    TextBox10_calleFacturacion.Text.Trim(),
                    TextBox14_telefonoFijo.Text.Trim(),
                    TextBox15_telefonoMovil.Text.Trim(),
                    TextBox4_correoPersonal.Text.Trim(),
                    TextBox5_correoLaboral.Text.Trim()
                )
            ' Mostrar un mensaje de éxito
            MsgBox("Datos guardados exitosamente")
            'Dejamos todo en blanco de nuevo luego de guardar correctamente
            TextBox1_rut.Text = ""
            TextBox2_nombre.Text = ""
            TextBox3_apellido1.Text = ""
            TextBox4_apellido2.Text = ""
            DateTimePicker1_fechaNacimiento.Value = DateTime.Now
            ComboBox_gruposanguineo.Text = ""
            ComboBox1_regionPersonal.Text = ""
            ComboBox2_comunaPersonal.Text = ""
            TextBox12_callePersonal.Text = ""
            ComboBox4_regionComercial.Text = ""
            ComboBox3_comunaComercial.Text = ""
            TextBox9_calleComercial.Text = ""
            ComboBox6_regionFacturacion.Text = ""
            ComboBox5_comunaFacturacion.Text = ""
            TextBox10_calleFacturacion.Text = ""
            TextBox14_telefonoFijo.Text = ""
            TextBox15_telefonoMovil.Text = ""
            TextBox4_correoPersonal.Text = ""
            TextBox5_correoLaboral.Text = ""
        End If
    End Sub
End Class