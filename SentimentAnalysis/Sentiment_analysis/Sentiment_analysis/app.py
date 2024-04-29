from data_utils.pipeline import prediction_pipeline
from flask import Flask, request, jsonify

app = Flask(__name__)

pipe = prediction_pipeline()
# Define a sample endpoint
@app.route('/hello', methods=['GET'])
def hello():
    return "Hello, World!"

# Define an endpoint that accepts POST requests with JSON data
@app.route('/predict', methods=['POST'])
def predict():
    # Get the JSON data from the request
    data = request.json
    text = data.get("text")
    if not text:
        return jsonify({"message":"text not found invalid request"})
    else:
        emoji_prediction, text_prediction = pipe.get_prediction(text)
        return jsonify({"text_prediction":text_prediction})

if __name__ == '__main__':
    app.run(debug=True)


