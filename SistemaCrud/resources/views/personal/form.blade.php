<h1>{{$modo}}  Registro</h1>

<label for="Nombre">Nombre</label>
<input type="text" name="Nombre" value="{{ isset($personal->Nombre)?$personal->Nombre:'' }}" id="Nombre"> <br>
<label for="Apellido">Apellido</label>
<input type="text" name="Apellidos"  value="{{ isset($personal->Apellidos)?$personal->Apellidos:''}}" id="Apellidos"><br>
<label for="Correo">Correo</label>
<input type="text" name="Correo"  value="{{ isset($personal->Correo)?$personal->Correo:'' }}"id="Correo"><br>
<label for="Telefono">Telefono</label>
<input type="tel" name="Telefono"  value="{{ isset($personal->Telefono)?$personal->Telefono:''}}" id="Telefono"><br>
<input type="submit" value="{{$modo}} datos" >
<br>
<a href="{{ url('/personal') }}">Regresar</a>