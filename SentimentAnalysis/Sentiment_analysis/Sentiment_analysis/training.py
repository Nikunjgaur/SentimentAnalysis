import numpy as np
import xgboost as xgb
from sklearn.model_selection import train_test_split
from sklearn.feature_extraction.text import TfidfVectorizer
from sklearn.metrics import accuracy_score
import pickle
import pandas as pd

def start_training(filepath):

    data = pd.read_csv(filepath)

    X_text = data["text"]
    label = data["label"]

    label_map = dict(zip( list(set(label)) ,list(range(len(set(label))))))
    y_text = data["label"].apply(lambda x : label_map.get(x))

    # Split the data into train and test sets
    X_train_text, X_test_text, y_train, y_test = train_test_split(X_text, y_text, test_size=0.2, random_state=42)

    # Convert text data into TF-IDF vectors
    tfidf_vectorizer = TfidfVectorizer(max_features=1000)  # Adjust max_features as needed
    X_train_tfidf = tfidf_vectorizer.fit_transform(X_train_text)
    X_test_tfidf = tfidf_vectorizer.transform(X_test_text)

    # Convert the TF-IDF matrices into DMatrix format
    dtrain = xgb.DMatrix(X_train_tfidf, label=y_train)
    dtest = xgb.DMatrix(X_test_tfidf, label=y_test)

    # Parameters for XGBoost model
    param = {
        'objective': 'multi:softmax',  # Multiclass classification
        'num_class': len(np.unique(y_train)),  # Number of unique classes in the dataset
        'eta': 0.1,                     # Learning rate
        'max_depth': 10,                 # Maximum depth of the tree
        'eval_metric': 'merror'         # Evaluation metric
    }

    # Train the XGBoost model
    num_round = 20
    bst = xgb.train(param, dtrain, num_round)

    # Make predictions
    preds = bst.predict(dtest)
    train_preds = bst.predict(dtrain)

    # Evaluate accuracy
    accuracy = accuracy_score(y_test, preds)
    train_accuracy = accuracy_score(y_train,train_preds)
    print("Train Accuracy:", train_accuracy)
    print("Test Accuracy:", accuracy)

    with open(r"./data/artifacts/vectorizer.pickle", "wb") as file:
        pickle.dump(tfidf_vectorizer, file)

    with open(r"./data/artifacts/label_map.pickle", "wb") as file:
        pickle.dump(label_map, file)

    with open(r"./data/artifacts/model.pickle", "wb") as file:
        pickle.dump(bst, file)

if __name__ == "__main__":
    start_training(r"D:\Add Inno\Projects\SentimentAnalysis\SentimentAnalysis\Sentiment_analysis\Sentiment_analysis\data\preprocessed_data.csv")



