// Copyright 2014 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace StoryBoxVR
{
    using UnityEngine;
    using UnityEngine.EventSystems;

    [RequireComponent(typeof(Collider))]
    public class ButtonManager : MonoBehaviour
    {
        private Renderer myRenderer;

        public Material inactiveMaterial;
        public Material gazedAtMaterial;

        void Start()
        {
            myRenderer = GetComponent<Renderer>();
        }

        public void SetGazedAt()
        {
            myRenderer.material = gazedAtMaterial;
        }

        public void SetUngazedAt() 
        {
            myRenderer.material = inactiveMaterial;
        }

        public void Recenter()
        {
#if !UNITY_EDITOR
      GvrCardboardHelpers.Recenter();
#else
            if (GvrEditorEmulator.Instance != null)
            {
                GvrEditorEmulator.Instance.Recenter();
            }
#endif  // !UNITY_EDITOR
        }

        public void OnSelect(BaseEventData eventData)
        {
            Debug.Log("yeeee here we go");
            Initiate.Fade("Main", Color.black, 2.0f);
        }
    }
}
