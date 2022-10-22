from modulefinder import IMPORT_NAME
from os import name
from typing import Text
from wsgiref.validate import validator
from flask import Flask, render_template, request, redirect, url_for
from "datos.html" import contador
app = Flask(__name__)
@app.route('/', methods=['GET', 'POST'])
def show_signup_form():
    return render_template('datos.html')
@app.route('/read', methods=['GET', 'POST'])
def read():
    nombre=request.form['name']
    nacimiento = request.form['nacimiento']
    ocupacion= request.form['ocupacion']
    contacto = request.form['contacto']
    nacionalidad = request.form['nacionalidad']
    ingles = request.form.get('nivel')
    leng = request.form.getlist('leng')
    apti = request.form['aptitudes']
    habi = request.form.getlist('hab')
    perfil= request.form['perfil1']
    return render_template('curriculum.html', nombre=nombre, nacimiento = nacimiento, ocupacion = ocupacion, contacto = contacto, nacionalidad = nacionalidad, ingles = ingles, leng = leng, apti = apti, habi = habi, perfil=perfil)