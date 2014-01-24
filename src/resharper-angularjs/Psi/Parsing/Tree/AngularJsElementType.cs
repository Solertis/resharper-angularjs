#region license
// Copyright 2013 JetBrains s.r.o.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.JavaScript.Tree;

namespace JetBrains.ReSharper.Plugins.AngularJS.Psi.Parsing.Tree
{
    public abstract class AngularJsElementType
    {
        public static readonly CompositeNodeType REPEAT_EXPRESSION = REPEAT_EXPRESSION_INTERNAL.INSTANCE;

        private class REPEAT_EXPRESSION_INTERNAL : JavaScriptCompositeNodeType
        {
            public static readonly REPEAT_EXPRESSION_INTERNAL INSTANCE = new REPEAT_EXPRESSION_INTERNAL(20000);

            private REPEAT_EXPRESSION_INTERNAL(int index)
                : base("REPEAT_EXPRESSION", index)
            {
            }

            public override CompositeElement Create()
            {
                return new RepeatExpression();
            }
        }
    }
}