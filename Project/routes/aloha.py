from modulefinder import IMPORT_NAME
from os import name
from flask import Flask, render_template, request, redirect, url_for
app = Flask(__name__)


@app.route("/", methods=["GET", "POST"])
def show_signup_form():
    return render_template("datos.html")
@app.route("/read", methods=["GET", "POST"])
def read():
    return render_template("curriculum.html", leng = request.form['leng'], ocupacion= request.form['ocupacion'], perfil= request.form['perfil1'], nacionalidad = request.form['nacionalidad'], nacimiento = request.form['nacimiento'], contacto = request.form['contacto'], nombre=request.form['name'])