from ultralytics import YOLO
DATASET_YAML = "dataset/data.yaml"

def main():
    model = YOLO("yolo11n.yaml").load("yolo11n.pt")
    results = model.train(data=DATASET_YAML, epochs=100, imgsz=640)

if __name__ == "__main__":
    import multiprocessing
    multiprocessing.freeze_support()  # for Windows
    main()
