import pickle
import xgboost as xgb
from data_utils.constants import EMOJI_MAP

class prediction_pipeline():

    def get_vectorizer(self):
        with open("./data/artifacts/vectorizer.pickle", "rb") as file:
            vectorizer = pickle.load(file)
        return vectorizer

    def get_label_map(self):
        with open("./data/artifacts/label_map.pickle", "rb") as file:
            label_map = pickle.load(file)
        return label_map

    def get_model(self):
        with open("./data/artifacts/model.pickle", "rb") as file:
            label_map = pickle.load(file)
        return label_map

    def get_prediction(self, text):
        vectorizer = self.get_vectorizer()
        label_map = self.get_label_map()
        model = self.get_model()

        vect = vectorizer.transform([text])
        sentence_vect = xgb.DMatrix(vect)
        preds = model.predict(sentence_vect)
        
        rev_label_map = dict(zip(label_map.values(), label_map.keys()))

        return EMOJI_MAP.get(rev_label_map.get(preds[0])), rev_label_map.get(preds[0])

if __name__ == "__main__":
    pipe = prediction_pipeline()
    print(pipe.get_prediction("i am sad because i lost my book"))


