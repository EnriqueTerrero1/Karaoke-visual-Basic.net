Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Button1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox2.Items.Add(ListBox1.SelectedItem)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label3.Text = ""
        If ListBox2.SelectedItem = "Los Infieles                                           Aventura                         Bachata                    The Last" Then

            PictureBox2.Visible = False
            AxWindowsMediaPlayer1.URL = My.Application.Info.DirectoryPath + "/02 Los Infieles.mp3"
        End If
        If ListBox2.SelectedItem = "Mejor lo Hago con las manos           Yiyo Sarante                       Salsa                         " Then
            PictureBox2.Visible = False
            AxWindowsMediaPlayer1.URL = My.Application.Info.DirectoryPath + "/Yiyo Sarante - Mejor Lo Hago Con La Mano Nuevo 2015.mp3"

        End If
        If ListBox2.SelectedItem = "Despacion                                   Daddy yankee ft luis fonsi     reguetton " Then
            PictureBox2.Visible = False
            AxWindowsMediaPlayer1.URL = My.Application.Info.DirectoryPath + "/Luis Fonsi - Despacito ft. Daddy Yankee.mp3"

        End If
        If ListBox2.SelectedItem = "Burbujas de Amor                           Juan Luis Guerra                  Bachata                   " Then
            PictureBox2.Visible = True
            AxWindowsMediaPlayer1.URL = My.Application.Info.DirectoryPath + "/Burbujas De Amor - Juan Luis Guerra - CON LETRA.mp3"

        End If
        If ListBox2.SelectedItem = "El Malo                                                  Aventura                          Bachata                    The Last" Then
            PictureBox2.Visible = False
            AxWindowsMediaPlayer1.URL = My.Application.Info.DirectoryPath + "/04.-El-Malo.mp3"
        End If
        If ListBox2.SelectedItem = "Que Se Mueran                                    Romeo Santos                 Bachata " Then
            PictureBox2.Visible = False
            AxWindowsMediaPlayer1.URL = My.Application.Info.DirectoryPath + "/03.Que Se Muera.mp3"
        End If



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim b As Double
        b = Math.Floor(AxWindowsMediaPlayer1.Ctlcontrols.currentPosition)
        Label4.Text = b.ToString()
        If ListBox2.SelectedItem = "Los Infieles                                           Aventura                         Bachata                    The Last" Then

            If Label4.Text = "4" Then
                Label3.Text = " you know we're not supposed to be doing this right?
No estamos supuestos a hacer esto.
This  is a sin, esto es un pecado.....
we're both going to hell...
vamos pal infierno"
            End If
            If Label4.Text = "17" Then
                Label3.Text = "Quitate la Ropa Lentamente Hoy
Quiero amanecer contigo....
(Hoy quiero amanecer contigo),
y cuidado si sospechan Los vecinos,
Mi mujer o tu marido....
(mi mujer o tu marido)"
            End If
            If Label4.Text = "35" Then
                Label3.Text = "Tú y yo durmiendo con los enemigos
Dos seres que jamás hemos querido...
Los dos saciando un bendito capricho
Donde somos masoquistas por
Volver a nuestros nidos."
            End If
            If Label4.Text = "49" Then
                Label3.Text = "Desnuda tal paso mi reina y sólo
Ámame, que el secreto permanezca
En un cuarto de hotel, te aseguro que
Esos tontos no van a entender
Que si les somos infieles es por
Un gran querer..."
            End If


            If Label4.Text = "63" Then
                Label3.Text = "Asi con cautela despacio solo amame 
Que si nos coje la noche Yo me inventare 
Una excusa, una entramada ella me lo cree 
Y tu di otra mentirita al idiota aquel "
            End If
            If Label4.Text = "77" Then
                Label3.Text = "Quitate la ropa lentamente quiero amanecer contigo 
(quiero amanecer contigo)
Y cuidado si sospechan los vecinos
, mi mujer, o tu marido 
( mi mujer o tu marido)"
            End If
            If Label4.Text = "91" Then

                Label3.Text = "Que nos perdone nuestro divino señor si 
cometemos un delito 
( cometemos un delito)
Pero Adan y Eva pecaron por tentacion tu y yo no 
somos distintos"

            End If
            If Label4.Text = "108" Then
                Label3.Text = " Que traviesos somos
Y que bien se siente!
I'm a bad boy

KOB"
            End If
            If Label4.Text = "139" Then

                Label3.Text = "  Desnudate al paso mi reina y solo amame
Que el secreto permanezca en un cuarto de hotel
Te aseguro que esos tontos no van a entender
Que si le somos infieles es por un gran querer"
            End If
            If Label4.Text = "154" Then



                Label3.Text = "Asi con cautela despacio solo amame
Que si nos coje la noche Yo me inventare
Una excusa, una entramada ella me lo cree
Y tu di otra mentirita al idiota aquel"

            End If
            If Label4.Text = "169" Then

                Label3.Text = " Quitate la ropa lentamente quiero amanecer contigo
(quiero amanecer contigo)
Y cuidado si sospechan los vecinos, mi mujer, o tu marido
(mi mujer o tu marido)
Que nos perdone nuestro divino señor si cometemos un delito
(cometemos un delito)
Pero Adan y Eva pecaron por tentacion tu y yo no 
somos distintos"


            End If
            If Label4.Text = "200" Then

                Label3.Text = "KOB
                You know... Aventura"
            End If
            If Label4.Text = "211" Then

                Label3.Text = " Hello baby!
Baby Where you at Is Like 8: 30 in the morning??
I know baby, I know, es que estoy atrapada en trafico
Estoy ahi en un par de horas, OK Bye
OK mi amor cuidate!!"
            End If
            If Label4.Text = "219" Then

                Label3.Text = "Shhhh
Dont make noise
Dont make noise
Keep it on the low
How come something feel so good knowing that Is wrong "

            End If
            If Label4.Text = "230" Then
                Label3.Text = "  Shhhh
                (So nasty)
                Keep it on the low
                How come something feel so good knowing that Is wrong"
            End If

            If Label4.Text = "237" Then
                Label3.Text = "  Shhhh Keep it on the low
 How come something feel so good knowing that Is wrong
Your kid Romeo could keep a secret
Shhhh Keep it on the low
Knowin that it's wrong
(Don't say nothin)
(Its just between us)"
            End If

        End If
            If ListBox2.SelectedItem = "Mejor lo Hago con las manos           Yiyo Sarante                       Salsa                         " Then
            If Label4.Text = "19" Then
                Label3.Text = "Sabes, quiero 
Agradecerte que 
Hayas preferido terminar 
Nuestras ilusiones 
Nunca se pudieron olvinar "
            End If
            If Label4.Text = "36" Then
                Label3.Text = "Gracias por haberte ido 
Como te pago el favor 
Y ahora que no estas 
Por razones obvias 
Tengo buen humor"
            End If
            If Label4.Text = "57" Then
                Label3.Text = "Gracias por no estar conmigo 
Por hacer eso por mi 
Al principio estaba herido 
No quería vivir sin ti"
            End If
            If label4.text = "74" Then
                Label3.Text = "Ahora que sigo soltero 
Me volví muy popular 
Ya no me molestes 
Deja de llamarme, a mi celular "
            End If
            If Label4.Text = "92" Then
                Label3.Text = "Vístete y date la vuelta 
No quiero volver a verte 
No te me pongas en frente 
En pura ropa interior 
Mejor lo hago con la mano 
A demás ya no me gusta 
Como luce, tu exterior "
            End If
            If Label4.Text = "110" Then
                Label3.Text = "Para que reflexionaras 
Te di mil explicaciones 
y te dije en mis sermones 
Que iba a desaparecer 
No se como me encontraste 
Pero te advierto que al sexo 
Contigo ya es aburrido 
Y ya no lo vamos hacer "

            End If
            If Label4.Text = "140" Then
                Label3.Text = "Gracias por no estar conmigo 
Tengo mi autoestima al cien 
Te puedes quitar las ganas 
Yo no se conque o con quien 
Con todos menos conmigo 
Yo deje de ser opción 
Y no es un invento 
Que hay otra persona 
En mi corazón "
            End If

            If Label4.Text = "174" Then
                Label3.Text = "Vístete y Date la vuelta 
No quiero volver a verte 
No te me pongas en frente 
En pura ropa interior 
Mejor lo hago con la mano 
A demás ya no me gusta 
Como luce, tu exterior"
            End If
            If Label4.Text = "194" Then
                Label3.Text = "Para que reflexionaras 
Te di mil explicaciones 
y te dije en mis sermones 
Que iba a desaparecer 
No se como me encontraste 
Pero te advierto que al sexo 
Tu sabes que yo tengo otra 
Ya no lo vamos hacer 
Mejor lo hago con la mano 
Ya no lo vamos hacer"
            End If

        End If
        If ListBox2.SelectedItem = "Despacion                                   Daddy yankee ft luis fonsi     reguetton " Then
            If Label4.Text = "26" Then
                Label3.Text = "Ay 
Fonsi 
DY 
Oh oh… 
Oh no, oh no… 
Oh 
Yeah… [
Dididiri Daddy 
"
            End If
            If Label4.Text = "41" Then
                Label3.Text = "Sí, sabes que ya llevo un rato mirándote 
Tengo que bailar contigo hoy (DY) 
Vi que tu mirada ya estaba llamándome 
Muéstrame el camino que yo voy (Oh) "
            End If
            If Label4.Text = "62" Then
                Label3.Text = "Tú, tú eres el imán y yo soy el metal 
Me voy acercando y voy armando el plan 
Solo con pensarlo se acelera el pulso (Oh yeah)"
            End If
            If Label4.Text = "73" Then
                Label3.Text = "Ya, ya me está gustando más de lo normal 
Todos mis sentidos van pidiendo más 
Esto hay que tomarlo sin ningún apuro"

            End If
            If Label4.Text = "83" Then
                Label3.Text = "Despacito 
Quiero respirar tu cuello despacito 
Deja que te diga cosas al oido 
Para que te acuerdes si no estás conmigo"

            End If
            If Label4.Text = "93" Then
                Label3.Text = "Despacito 
Quiero desnudarte a besos despacito 
Firmo en las paredes de tu laberinto 
Y hacer de tu cuerpo todo un manuscrito"
            End If
            If Label4.Text = "103" Then
                Label3.Text = "Sube sube 
Sube, sube, sube "
            End If
            If Label4.Text = "105" Then
                Label3.Text = "Quiero ver bailar tu pelo 
Quiero ser tu ritmo 
Que le enseñes a mi boca 
Tus lugares favoritos (Favorito, favorito baby)"
            End If
            If Label4.Text = "116" Then
                Label3.Text = "Déjame sobrepasar tus zonas de peligro 
Hasta provocar tus gritos 
Y que olvides tu apellido "
            End If
            If Label4.Text = "126" Then
                Label3.Text = "Si te pido un beso ven dámelo 
Yo sé que estás pensándolo 
Llevo tiempo intentándolo 
Mami esto es dando y dandolo"

            End If
            If Label4.Text = "132" Then
                Label3.Text = "Sabes que tu corazón conmigo te hace bom bom 
Sabes que esa beba está buscando de mi bom bom"
            End If
            If Label4.Text = "137" Then
                Label3.Text = "Ven prueba de mi boca para ver como te sabe 
quiero quiero quiero ver cuanto amor a ti te cabe 
Yo no tengo prisa yo me quiero dar el viaje 
Empecemos lento, después salvaje"
            End If
            If Label4.Text = "148" Then
                Label3.Text = "Pasito a pasito, suave suavecito 
Nos vamos pegando, poquito a poquito 
cuando tú me besas con esa destreza 
Veo que eres malicia con delicadeza"
            End If
            If Label4.Text = "159" Then
                Label3.Text = "Pasito a pasito, suave suavecito 
Nos vamos pegando, poquito a poquito 
Y es que esa belleza es un rompecabezas 
Pero pa montarlo aquí tengo la pieza, (oye)"

            End If
            If Label4.Text = "171" Then
                Label3.Text = "Despacito 
Quiero respirar tu cuello despacito 
Deja que te diga cosas al oido 
Para que te acuerdes si no estás conmigo"

            End If
            If Label4.Text = "181" Then
                Label3.Text = "Despacito 
Quiero desnudarte a besos despacito 
Firmo en las paredes de tu laberinto 
Y hacer de tu cuerpo todo un manuscrito"

            End If
            If Label4.Text = "191" Then
                Label3.Text = "Sube, sube, sube, sube, sube "

            End If
            If Label4.Text = "193" Then
                Label3.Text = "Quiero ver bailar tu pelo 
Quiero ser tu ritmo 
Que le enseñes a mi boca 
Tus lugares favoritos (Favorito, favorito baby)"
            End If
            If Label4.Text = "204" Then
                Label3.Text = "Déjame sobrepasar tus zonas de peligro 
Hasta provocar tus gritos 
Y que olvides tu apellido"
            End If
            If Label4.Text = "214" Then
                Label3.Text = "Despacito 
Vamos a hacerlo en una playa en Puerto Rico 
hasta que las olas griten Ay Bendito 
Para que mi sello se quede contigo"
            End If

        End If
        If Label4.Text = "225" Then
            Label3.Text = ""
        End If
        If ListBox2.Text = "Burbujas de Amor                           Juan Luis Guerra                  Bachata                   " Then
            If Label4.Text = "6" Then
                Label3.Text = "Tengo un corazón
Mutilado de esperanza y de razón
Tengo un corazón que madruga donde quiera"
            End If

            If Label4.Text = "20" Then
                Label3.Text = "¡ay!..
Y este corazón
Se desnuda de impaciencia
Ante tu voz,
Pobre corazón
Que no atrapa su cordura"

            End If
            If Label4.Text = "35" Then
                Label3.Text = "Quisiera ser un pez
Para tocar mi nariz en tu pecera
Y hacer burbujas de amor por dondequiera
Pasar la noche en vela
Mojado en ti"
            End If
            If Label4.Text = "51" Then
                Label3.Text = "Un pez
Para bordar de corales tu cintura
Y hacer ciluetas de amor baja la luna
Saciar esta locura
Mojado en ti"
            End If
            If Label4.Text = "83" Then
                Label3.Text = "Canta corazón
Con un ancla imprescindible de ilusión
Sueña corazón
No te nubles de amargura"
            End If
            If Label4.Text = "98" Then
                Label3.Text = "Y este corazón
Se desnuda de impaciencia
Ante tu voz,
Pobre corazón
Que no atrapa su cordura"
            End If
            If Label4.Text = "112" Then
                Label3.Text = "Quisiera ser un pez
Para tocar mi nariz en tu pecera
Y hacer burbujas de amor por dondequiera
Pasar la noche en vela
Mojado en ti"
            End If
            If Label4.Text = "127" Then
                Label3.Text = "Un pez
Para bordar de corales tu cintura
Y hacer ciluetas amor bajo la luna
Saciar esta locura
Mojado en ti"
            End If
            If Label4.Text = "145" Then
                Label3.Text = "Una noche
Para hundirnos hasta el fin
Cara a cara
Beso a beso
Y vivir
Por siempre
Mojado en ti"
            End If
            If Label4.Text = "178" Then
                Label3.Text = "Quisiera ser un pez
Para tocar mi nariz en tu pecera
Y hacer burbujas de amor por dondequiera
Pasar la noche en vela
Mojado en ti"
            End If
            If Label4.Text = "194" Then
                Label3.Text = "Un pez
Para bordar de cayenas tu cintura
Y hacer ciluetas de amor bajo la luna
Saciar esta locura
Mojado en ti"
            End If
            If Label4.Text = "211" Then
                Label3.Text = "Para tocar mi nariz en tu pecera
Y hacer burbujas de amor por dondequiera"
            End If
            If Label4.Text = "220" Then
                Label3.Text = "Pasar la noche en vela
Mojado en ti"
            End If
            If Label4.Text = "225" Then
                Label3.Text = "Un pez
Para bordar de cayenas tu cintura
Y hacer ciluetas de amor bajo la luna
Saciar esta locura
Mojado en ti"
            End If


        End If
        If ListBox2.SelectedItem = "El Malo                                                  Aventura                          Bachata                    The Last" Then
            If Label4.Text = "9" Then
                Label3.Text = "El te da su amor, tu duermes con dudas.
Ahora ves que la costumbre no es lo que aparenta ser.
Es tan sincero, contrario a mis defectos,
pero sigo siendo el malo que no dejas de querer."
            End If
            If Label4.Text = "27" Then
                Label3.Text = "Tu seras La cinderella, el, el tonto que da pena, 
y aunque yo no sea un principe azul.
Soy tu amor, y tu dilemma, y al igual que en las novelas,
soy el malo con una virtud"
            End If
            If Label4.Text = "44" Then
                Label3.Text = "El no entiende el procedimiento, cuando y como darte un beso.
Yo en cambio encuentro el punto debil, que te eleva hasta el exceso."
            End If
            If Label4.Text = "58" Then
                Label3.Text = "Nisiquiera se imagina de ese pacto misterioso con tu alma y tu cerebro.
Tendrias que volver a nacer, para ver si en otra vida te enamoras de el."
            End If
            If Label4.Text = "75" Then
                Label3.Text = "No tiene la tactica adecuada pa' arrancarme de tu pecho.
Yo que te falle mil veces, sigo siendo tu dueño."
            End If
            If Label4.Text = "88" Then
                Label3.Text = "Que me pregunte como te conquiste.
Que anote mis truquitos en papel.
No basta los morales, y ser fiel.
Si tu deliras por el malo que te heriza la piel. 
(so nasty...yes sir)"
            End If
            If Label4.Text = "132" Then
                Label3.Text = "Tu seras La cinderella, el, el tonto que da pena, 
y aunque yo no sea un principe azul.
Soy tu amor, y tu dilemma, y al igual que en las novelas, 
soy el malo con una virtud"
            End If
            If Label4.Text = "149" Then
                Label3.Text = "El no entiende el procedimiento,
cuando y como darte un beso.
Yo en cambio encuentro el punto debil, 
que te eleva hasta el exceso."
            End If
            If Label4.Text = "164" Then
                Label3.Text = "Nisiquiera se imagina de ese pacto misterioso con tu alma y tu cerebro.
Tendrias que volver a nacer, para ver si en otra vida te enamoras de el."
            End If
            If Label4.Text = "180" Then
                Label3.Text = "No tiene la tactica adecuada pa' arrancarme de tu pecho.
Yo que te falle mil veces, sigo siendo tu dueno."
            End If
            If Label4.Text = "194" Then
                Label3.Text = "Que me pregunte como te conquiste.
Que anote mis truquitos en papel.
No basta los morales, y ser fiel.
Si tu deliras por el malo que te heriza la piel."
            End If
            If Label4.Text = "225" Then
                Label3.Text = "El te da su amor, tu duermes con dudas.
y yo sigo siendo el malo que no dejas de querer."
            End If

        End If
        If ListBox2.SelectedItem = "Que Se Mueran                                    Romeo Santos                 Bachata " Then
            If Label4.Text = "1" Then
                Label3.Text = "Andan murmurando
Que lo nuestro no es debido
Y le faltan el respeto
Sin derecho, a nuestro amor"
            End If
            If Label4.Text = "14" Then
                Label3.Text = "Por cuestión social
Y diferencia en las edades
Estos tontos ignorantes
No me quieren ver contigo"
            End If
            If Label4.Text = "27" Then
                Label3.Text = "No tienen razón, esto no es correcto
Y si se arrepienten
No merecen penitencia
Porque en el amor
No hay economía ni una edad
Precisa pa' que dos se quieran"
            End If
            If Label4.Text = "44" Then
                Label3.Text = "Que se mueran los incrédulos
Envidiosos si nos tronchan el destino"
            End If
            If Label4.Text = "52" Then
                Label3.Text = "No lo duden una lengua venenosa
Es más mortal que un cuchillo
Que caigan todos en abismo
Si es que no aceptan nuestro idilio"
            End If
            If Label4.Text = "68" Then
                Label3.Text = "Qué demonio importa
El estatus económico
Si el alma, no tiene valor"

            End If
            If Label4.Text = "74" Then
                Label3.Text = "Que tu tienes 30 y yo apenas 24
Son numeritos que fastidio"
            End If
            If Label4.Text = "87" Then
                Label3.Text = " No tienen razón, esto no es correcto
Y si se arrepienten
No merecen penitencia
Porque en el amor
No hay economía ni una edad
Precisa pa' que dos se quieran"
            End If
            If Label4.Text = "104" Then
                Label3.Text = "Que se mueran los incrédulos
Envidiosos si nos tronchan el destino"
            End If
            If Label4.Text = "112" Then
                Label3.Text = "No lo duden una lengua venenosa
Es más mortal que un cuchillo
Que caigan todos en abismo
Si es que no aceptan nuestro idilio"

            End If
            If Label4.Text = "132" Then
                Label3.Text = "Sigan criticando, sigan hablando

"

            End If
        End If



    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        AxWindowsMediaPlayer1.settings.volume = TrackBar1.Value
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox2.SelectedIndex > -1 Then
            ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
            AxWindowsMediaPlayer1.Ctlcontrols.pause()

        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint



    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        Panel3.Dock = DockStyle.None
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel3.BringToFront()
        Panel3.Dock = DockStyle.Fill
        PictureBox2.Dock = DockStyle.Fill
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox2.Dock = DockStyle.None
        Panel3.Dock = DockStyle.None
    End Sub
End Class
