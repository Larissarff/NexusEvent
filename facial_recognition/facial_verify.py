import os
import traceback

os.environ["CUDA_VISIBLE_DEVICES"] = "-1"
os.environ["DISPLAY"] = ""
os.environ["QT_QPA_PLATFORM"] = "offscreen"

import sys
import os.path

from deepface import DeepFace

user_id = " virá do endpoint do C#"
webcam_image_path = "caminho para foto webcam"
reference_image_path = "caminho para foto referencia no banco do user"

if not os.path.isfile(reference_image_path):
    print(f"ERROR: Imagem de referência não encontrada em '{reference_image_path}'")
    sys.exit(1)

if not os.path.isfile(webcam_image_path):
    print(f"ERROR: Imagem da webcam não encontrada em '{webcam_image_path}'")
    sys.exit(1)

try:
    result = DeepFace.verify(
        img1_path=webcam_image_path,
        img2_path=reference_image_path,
        model_name="ArcFace",
        detector_backend="yolov8",
        enforce_detection=False,
    )

    if result.get("verified"):
        print("RESULT:SUCCESS")
    else:
        print("RESULT:FAIL")

except Exception as e:
    print(f"ERROR: {type(e).__name__}: {str(e)}")
    traceback.print_exc()
    sys.exit(1)