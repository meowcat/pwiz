﻿/*
 * Original author: Nicholas Shulman <nicksh .at. u.washington.edu>,
 *                  MacCoss Lab, Department of Genome Sciences, UW
 *
 * Copyright 2018 University of Washington - Seattle, WA
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Windows.Forms;
using pwiz.Common.DataBinding.Controls;
using pwiz.Skyline.Model;
using pwiz.Skyline.Model.Databinding;

namespace pwiz.Skyline.Controls.Databinding.RowActions
{
    /// <summary>
    /// Base class for menu items which appear on the "Actions" dropdown on the Document Grid.
    /// These operations act on the selected rows in a BoundDataGridView.
    /// </summary>
    public abstract class RowAction
    {
        public abstract ToolStripMenuItem CreateMenuItem(SrmDocument.DOCUMENT_TYPE documentType, BoundDataGridView dataGridView);
        public abstract string GetMenuItemText(SrmDocument.DOCUMENT_TYPE documentType);

        protected SkylineWindow GetSkylineWindow(BoundDataGridView dataGridView)
        {
            return ((SkylineDataSchema)((BindingListSource)dataGridView.DataSource).ViewContext.DataSchema).SkylineWindow;
        }
    }
}
