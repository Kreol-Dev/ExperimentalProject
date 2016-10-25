namespace generators {
    
    
    public class locations_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar4 = default(System.Boolean); //IsContext = False IsNew = False
			Space StoredVariable0 = ((Space)root.GetComponent(typeof(Space))); //IsContext = False IsNew = False
			if(StoredVariable0 != null)
			{
				System.Boolean ifResult1; //IsContext = False IsNew = False
				
				System.Collections.Generic.List<Place> OperandVar3 = default(System.Collections.Generic.List<Place>); //IsContext = False IsNew = False
				System.Collections.Generic.List<Place> prop2 = StoredVariable0.Places; //IsContext = False IsNew = False
				if(prop2 != null)
				{
					OperandVar3 = prop2;
				}
				
				
				if(ifResult1 = ( ( (OperandVar3 != null ? OperandVar3.Count : 0))) == ( ( (0f))))
				{
					applicable = true;
					OperandVar4 = applicable;
				}
			}
			return (System.Boolean) (OperandVar4);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Space subContext5 = (Space)root.GetComponent(typeof(Space)); //IsContext = True IsNew = False
				//ContextStatement Space subContext5 ContextSwitchInterpreter
				if(subContext5 != null)
				{
					
					subContext5.Size = (System.Int32)( (5f));
					System.Single OperandVar7 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop6 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar7 = prop6;
					for (int i = 0; i <  (OperandVar7); i++)
					{
						UnityEngine.GameObject loc = new UnityEngine.GameObject("loc"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject loc8 = loc; //IsContext = True IsNew = False
							Entity AddContext9 = (Entity)loc.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Entity AddContext9 ContextSwitchInterpreter
								if(AddContext9 != null)
								{
									UnityEngine.Vector3 OperandVar19 = default(UnityEngine.Vector3); //IsContext = False IsNew = False
									System.Single OperandVar13 = default(System.Single); //IsContext = False IsNew = False
									
									System.Int32 OperandVar11 = default(System.Int32); //IsContext = False IsNew = False
									System.Int32 prop10 = External.MapX(); //IsContext = False IsNew = False
									OperandVar11 = prop10;
									System.Single prop12 = External.Random( (0f), (OperandVar11)); //IsContext = False IsNew = False
									OperandVar13 = prop12;
									System.Single OperandVar17 = default(System.Single); //IsContext = False IsNew = False
									
									System.Int32 OperandVar15 = default(System.Int32); //IsContext = False IsNew = False
									System.Int32 prop14 = External.MapX(); //IsContext = False IsNew = False
									OperandVar15 = prop14;
									System.Single prop16 = External.Random( (0f), (OperandVar15)); //IsContext = False IsNew = False
									OperandVar17 = prop16;
									UnityEngine.Vector3 prop18 = External.Vec( (OperandVar13), (OperandVar17)); //IsContext = False IsNew = False
									OperandVar19 = prop18;
									AddContext9.Position = (UnityEngine.Vector3)( (OperandVar19));
								}
							}
							Place AddContext20 = (Place)loc.AddComponent(typeof(Place)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Place AddContext20 ContextSwitchInterpreter
								if(AddContext20 != null)
								{
									System.Single OperandVar22 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop21 = External.Random( (1f), (3f)); //IsContext = False IsNew = False
									OperandVar22 = prop21;
									AddContext20.Size = (System.Int32)( (OperandVar22));
								}
							}
							Markers AddContext23 = (Markers)loc.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Markers AddContext23 ContextSwitchInterpreter
								if(AddContext23 != null)
								{
									System.String OperandVar24 = default(System.String); //IsContext = False IsNew = False
									OperandVar24 = "history_place";
									AddContext23.SetMarker(( (OperandVar24)).ToString());
								}
							}
							Named AddContext25 = (Named)loc.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext25 ContextSwitchInterpreter
								if(AddContext25 != null)
								{
									
									
									
									AddContext25.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Location of: ")).ToString());
									
									
									System.String OperandVar28 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar26 = default(System.String); //IsContext = False IsNew = False
									OperandVar26 = "human_name";
									System.String prop27 = External.RandomName( (OperandVar26)); //IsContext = False IsNew = False
									if(prop27 != null)
									{
										OperandVar28 = prop27;
									}
									AddContext25.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar28)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(loc);
						Place OperandVar30 = default(Place); //IsContext = False IsNew = False
						Place StoredVariable29 = ((Place)loc.GetComponent(typeof(Place))); //IsContext = False IsNew = False
						if(StoredVariable29 != null)
						{
							OperandVar30 = StoredVariable29;
						}
						subContext5.Attach((Place)( (OperandVar30)));
					}
				}
			}
		}
        }
    }
    
    public class named_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar44 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable31 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable31 != null)
			{
				Markers StoredVariable32 = ((Markers)StoredVariable31.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable32 != null)
				{
					System.Boolean ifResult33; //IsContext = False IsNew = False
					
					System.Boolean OperandVar40 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable31 != null)
					{
						UnityEngine.GameObject prop34 = StoredVariable31.ShowedObject; //IsContext = False IsNew = False
						if(prop34 != null)
						{
							System.Boolean ifResult35; //IsContext = False IsNew = False
							System.Boolean OperandVar39 = default(System.Boolean); //IsContext = False IsNew = False
							Named OperandVar37 = default(Named); //IsContext = False IsNew = False
							Named StoredVariable36 = ((Named)prop34.GetComponent(typeof(Named))); //IsContext = False IsNew = False
							if(StoredVariable36 != null)
							{
								OperandVar37 = StoredVariable36;
							}
							System.Boolean prop38 = External.Has( (OperandVar37)); //IsContext = False IsNew = False
							OperandVar39 = prop38;
							if(ifResult35 =  (OperandVar39))
							{
								OperandVar40 = ifResult35;
							}
						}
					}
					
					System.Boolean OperandVar43 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar41 = default(System.String); //IsContext = False IsNew = False
					OperandVar41 = "named_ui_marker";
					System.Boolean prop42 = StoredVariable32.HasMarker( (OperandVar41)); //IsContext = False IsNew = False
					OperandVar43 = prop42;
					if(ifResult33 = ( ( (OperandVar40))) && ( (!(OperandVar43))))
					{
						applicable = true;
						OperandVar44 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar44);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext45 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext45 ContextSwitchInterpreter
				if(subContext45 != null)
				{
					System.String OperandVar46 = default(System.String); //IsContext = False IsNew = False
					OperandVar46 = "named_ui_marker";
					subContext45.SetUiMarker(( (OperandVar46)).ToString());
				}
			}
			
			{
				UiObject subContext47 = (UiObject)root.GetComponent(typeof(UiObject)); //IsContext = True IsNew = False
				//ContextStatement UiObject subContext47 ContextSwitchInterpreter
				if(subContext47 != null)
				{
					Named OperandVar50 = default(Named); //IsContext = False IsNew = False
					UnityEngine.GameObject prop48 = subContext47.ShowedObject; //IsContext = False IsNew = False
					if(prop48 != null)
					{
						Named StoredVariable49 = ((Named)prop48.GetComponent(typeof(Named))); //IsContext = False IsNew = False
						if(StoredVariable49 != null)
						{
							OperandVar50 = StoredVariable49;
						}
					}
					Named showed_named =  (OperandVar50); //IsContext = False IsNew = False
					TextField ContextVar51 = root.AddComponent<TextField>();; //IsContext = False IsNew = True
					
					{
						//ContextStatement TextField ContextVar51 ContextSwitchInterpreter
						if(ContextVar51 != null)
						{
							System.String OperandVar53 = default(System.String); //IsContext = False IsNew = False
							System.String prop52 = showed_named.FullName; //IsContext = False IsNew = False
							if(prop52 != null)
							{
								OperandVar53 = prop52;
							}
							ContextVar51.Show(( (OperandVar53)).ToString());
							
							{
								//ContextStatement Named showed_named ContextSwitchInterpreter
								if(showed_named != null)
								{
									VoidDelegate Lambda54 = () => 
									{
										System.String OperandVar56 = default(System.String); //IsContext = False IsNew = False
										System.String prop55 = showed_named.FullName; //IsContext = False IsNew = False
										if(prop55 != null)
										{
											OperandVar56 = prop55;
										}
										ContextVar51.Show(( (OperandVar56)).ToString());
									};
									showed_named.OnUpdate(Lambda54);
								}
							}
							
							{
								UnityEngine.UI.LayoutElement subContext57 = ContextVar51.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext57 ContextPropertySwitchInterpreter
								if(subContext57 != null)
								{
									
									subContext57.minHeight = (System.Single)( (20f));
								}
							}
						}
					}
					Entity EntVar58 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
					if(EntVar58 != null) EntVar58.ComponentAdded();
				}
			}
		}
        }
    }
    
    public class place_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar72 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable59 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable59 != null)
			{
				UiObject StoredVariable60 = ((UiObject)StoredVariable59.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
				if(StoredVariable60 != null)
				{
					System.Boolean ifResult61; //IsContext = False IsNew = False
					
					System.Boolean OperandVar68 = default(System.Boolean); //IsContext = False IsNew = False
					UnityEngine.GameObject prop62 = StoredVariable60.ShowedObject; //IsContext = False IsNew = False
					if(prop62 != null)
					{
						System.Boolean ifResult63; //IsContext = False IsNew = False
						System.Boolean OperandVar67 = default(System.Boolean); //IsContext = False IsNew = False
						Place OperandVar65 = default(Place); //IsContext = False IsNew = False
						Place StoredVariable64 = ((Place)prop62.GetComponent(typeof(Place))); //IsContext = False IsNew = False
						if(StoredVariable64 != null)
						{
							OperandVar65 = StoredVariable64;
						}
						System.Boolean prop66 = External.Has( (OperandVar65)); //IsContext = False IsNew = False
						OperandVar67 = prop66;
						if(ifResult63 =  (OperandVar67))
						{
							OperandVar68 = ifResult63;
						}
					}
					
					System.Boolean OperandVar71 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar69 = default(System.String); //IsContext = False IsNew = False
					OperandVar69 = "place_ui_set";
					System.Boolean prop70 = StoredVariable59.HasMarker( (OperandVar69)); //IsContext = False IsNew = False
					OperandVar71 = prop70;
					if(ifResult61 = ( ( (OperandVar68))) && ( (!(OperandVar71))))
					{
						applicable = true;
						OperandVar72 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar72);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext73 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext73 ContextSwitchInterpreter
				if(subContext73 != null)
				{
					System.String OperandVar74 = default(System.String); //IsContext = False IsNew = False
					OperandVar74 = "place_ui_set";
					subContext73.SetUiMarker(( (OperandVar74)).ToString());
				}
			}
			
			{
				UiObject subContext75 = (UiObject)root.GetComponent(typeof(UiObject)); //IsContext = True IsNew = False
				//ContextStatement UiObject subContext75 ContextSwitchInterpreter
				if(subContext75 != null)
				{
					Place OperandVar78 = default(Place); //IsContext = False IsNew = False
					UnityEngine.GameObject prop76 = subContext75.ShowedObject; //IsContext = False IsNew = False
					if(prop76 != null)
					{
						Place StoredVariable77 = ((Place)prop76.GetComponent(typeof(Place))); //IsContext = False IsNew = False
						if(StoredVariable77 != null)
						{
							OperandVar78 = StoredVariable77;
						}
					}
					Place pl =  (OperandVar78); //IsContext = False IsNew = False
					Blackboards.place_ui_data puidata = root.AddComponent<Blackboards.place_ui_data>();; //IsContext = False IsNew = True
					Entity EntVar79 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
					
					
					{
						//ContextStatement Blackboards.place_ui_data puidata ContextSwitchInterpreter
						if(puidata != null)
						{
							System.Int32 OperandVar81 = default(System.Int32); //IsContext = False IsNew = False
							System.Int32 prop80 = pl.Size; //IsContext = False IsNew = False
							OperandVar81 = prop80;
							puidata.LastSize = (System.Int32)( (OperandVar81));
						}
					}
					TextField ContextVar82 = root.AddComponent<TextField>();; //IsContext = False IsNew = True
					
					{
						//ContextStatement TextField ContextVar82 ContextSwitchInterpreter
						if(ContextVar82 != null)
						{
							System.Int32 OperandVar84 = default(System.Int32); //IsContext = False IsNew = False
							System.Int32 prop83 = pl.Size; //IsContext = False IsNew = False
							OperandVar84 = prop83;
							ContextVar82.Show(( (OperandVar84)).ToString());
							System.Boolean OperandVar88 = default(System.Boolean); //IsContext = False IsNew = False
							Updated OperandVar86 = default(Updated); //IsContext = False IsNew = False
							Updated StoredVariable85 = ((Updated)ContextVar82.GetComponent(typeof(Updated))); //IsContext = False IsNew = False
							if(StoredVariable85 != null)
							{
								OperandVar86 = StoredVariable85;
							}
							System.Boolean prop87 = External.Has( (OperandVar86)); //IsContext = False IsNew = False
							OperandVar88 = prop87;
							if(!(OperandVar88))
							{
								root.AddComponent<Updated>();
								
							}
							
							{
								//ContextStatement TextField ContextVar82 ContextSwitchInterpreter
								if(ContextVar82 != null)
								{
									
									ContextVar82.Label = (System.String)( ("size"));
								}
							}
							
							{
								UnityEngine.UI.LayoutElement subContext89 = ContextVar82.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext89 ContextPropertySwitchInterpreter
								if(subContext89 != null)
								{
									
									subContext89.minHeight = (System.Single)( (20f));
								}
							}
							
							{
								Updated subContext90 = (Updated)root.GetComponent(typeof(Updated)); //IsContext = True IsNew = False
								//ContextStatement Updated subContext90 ContextSwitchInterpreter
								if(subContext90 != null)
								{
									BoolDelegate Lambda91 = () => 
									{
										System.Boolean return_value = default(System.Boolean); //IsContext = False IsNew = False
										
										{
											//ContextStatement Place pl ContextSwitchInterpreter
											if(pl != null)
											{
												
												{
													//ContextStatement Blackboards.place_ui_data puidata ContextSwitchInterpreter
													if(puidata != null)
													{
														
														
														System.Int32 OperandVar93 = default(System.Int32); //IsContext = False IsNew = False
														if(pl != null)
														{
															System.Int32 prop92 = pl.Size; //IsContext = False IsNew = False
															OperandVar93 = prop92;
														}
														
														System.Int32 OperandVar95 = default(System.Int32); //IsContext = False IsNew = False
														if(puidata != null)
														{
															System.Int32 prop94 = puidata.LastSize; //IsContext = False IsNew = False
															OperandVar95 = prop94;
														}
														if(!(( ( (OperandVar93))) == ( ( (OperandVar95)))))
														{
															System.Int32 OperandVar97 = default(System.Int32); //IsContext = False IsNew = False
															if(pl != null)
															{
																System.Int32 prop96 = pl.Size; //IsContext = False IsNew = False
																OperandVar97 = prop96;
															}
															puidata.LastSize = (System.Int32)( (OperandVar97));
															System.Int32 OperandVar99 = default(System.Int32); //IsContext = False IsNew = False
															if(pl != null)
															{
																System.Int32 prop98 = pl.Size; //IsContext = False IsNew = False
																OperandVar99 = prop98;
															}
															ContextVar82.Show(( (OperandVar99)).ToString());
														}
													}
												}
											}
										}
										return return_value;
									};
									subContext90.OnUpdate(Lambda91);
								}
							}
						}
					}
					if(EntVar79 != null) EntVar79.ComponentAdded();
				}
			}
		}
        }
    }
    
    public class agents_pool_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar108 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable100 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable100 != null)
			{
				Place StoredVariable101 = ((Place)StoredVariable100.GetComponent(typeof(Place))); //IsContext = False IsNew = False
				if(StoredVariable101 != null)
				{
					System.Boolean ifResult102; //IsContext = False IsNew = False
					
					
					System.Collections.Generic.List<Agent> OperandVar104 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
					System.Collections.Generic.List<Agent> prop103 = StoredVariable101.Agents; //IsContext = False IsNew = False
					if(prop103 != null)
					{
						OperandVar104 = prop103;
					}
					
					
					
					System.Boolean OperandVar107 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar105 = default(System.String); //IsContext = False IsNew = False
					OperandVar105 = "agents_pool";
					System.Boolean prop106 = StoredVariable100.HasMarker( (OperandVar105)); //IsContext = False IsNew = False
					OperandVar107 = prop106;
					if(ifResult102 = ( (( ( (OperandVar104 != null ? OperandVar104.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar107))))
					{
						applicable = true;
						OperandVar108 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar108);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Place subContext109 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext109 ContextSwitchInterpreter
				if(subContext109 != null)
				{
					
					subContext109.Size = (System.Int32)( (5f));
					System.Single OperandVar111 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop110 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar111 = prop110;
					for (int i = 0; i <  (OperandVar111); i++)
					{
						UnityEngine.GameObject ag = new UnityEngine.GameObject("ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject ag112 = ag; //IsContext = True IsNew = False
							Entity AddContext113 = (Entity)ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							Agent AddContext114 = (Agent)ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.human AddContext115 = (Blackboards.human)ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Blackboards.human AddContext115 ContextSwitchInterpreter
								if(AddContext115 != null)
								{
									System.Single OperandVar117 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop116 = External.Random( (20f), (45f)); //IsContext = False IsNew = False
									OperandVar117 = prop116;
									AddContext115.Age = (System.Int32)( (OperandVar117));
								}
							}
							Named AddContext118 = (Named)ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext118 ContextSwitchInterpreter
								if(AddContext118 != null)
								{
									
									
									
									AddContext118.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Agent: ")).ToString());
									
									
									System.String OperandVar121 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar119 = default(System.String); //IsContext = False IsNew = False
									OperandVar119 = "human_name";
									System.String prop120 = External.RandomName( (OperandVar119)); //IsContext = False IsNew = False
									if(prop120 != null)
									{
										OperandVar121 = prop120;
									}
									AddContext118.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar121)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(ag);
						Agent OperandVar123 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable122 = ((Agent)ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable122 != null)
						{
							OperandVar123 = StoredVariable122;
						}
						subContext109.Attach((Agent)( (OperandVar123)));
					}
				}
			}
		}
        }
    }
    
    public class location_event : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar130 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable124 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable124 != null)
			{
				System.Boolean ifResult125; //IsContext = False IsNew = False
				System.Boolean OperandVar129 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.event_marker OperandVar127 = default(Blackboards.event_marker); //IsContext = False IsNew = False
				Blackboards.event_marker StoredVariable126 = ((Blackboards.event_marker)StoredVariable124.GetComponent(typeof(Blackboards.event_marker))); //IsContext = False IsNew = False
				if(StoredVariable126 != null)
				{
					OperandVar127 = StoredVariable126;
				}
				System.Boolean prop128 = External.Has( (OperandVar127)); //IsContext = False IsNew = False
				OperandVar129 = prop128;
				if(ifResult125 = !(OperandVar129))
				{
					applicable = true;
					OperandVar130 = applicable;
				}
			}
			return (System.Boolean) (OperandVar130);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.event_marker>();
			Entity EntVar131 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar131 != null) EntVar131.ComponentAdded();
		}
        }
    }
    
    public class agent_personality : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar138 = default(System.Boolean); //IsContext = False IsNew = False
			Agent StoredVariable132 = ((Agent)root.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
			if(StoredVariable132 != null)
			{
				System.Boolean ifResult133; //IsContext = False IsNew = False
				System.Boolean OperandVar137 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.personality OperandVar135 = default(Blackboards.personality); //IsContext = False IsNew = False
				Blackboards.personality StoredVariable134 = ((Blackboards.personality)StoredVariable132.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable134 != null)
				{
					OperandVar135 = StoredVariable134;
				}
				System.Boolean prop136 = External.Has( (OperandVar135)); //IsContext = False IsNew = False
				OperandVar137 = prop136;
				if(ifResult133 = !(OperandVar137))
				{
					applicable = true;
					OperandVar138 = applicable;
				}
			}
			return (System.Boolean) (OperandVar138);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.personality>();
			Entity EntVar139 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar139 != null) EntVar139.ComponentAdded();
		}
        }
    }
    
    public class aged_generation_add : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar146 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.human StoredVariable140 = ((Blackboards.human)root.GetComponent(typeof(Blackboards.human))); //IsContext = False IsNew = False
			if(StoredVariable140 != null)
			{
				System.Boolean ifResult141; //IsContext = False IsNew = False
				System.Boolean OperandVar145 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.aged_generation OperandVar143 = default(Blackboards.aged_generation); //IsContext = False IsNew = False
				Blackboards.aged_generation StoredVariable142 = ((Blackboards.aged_generation)StoredVariable140.GetComponent(typeof(Blackboards.aged_generation))); //IsContext = False IsNew = False
				if(StoredVariable142 != null)
				{
					OperandVar143 = StoredVariable142;
				}
				System.Boolean prop144 = External.Has( (OperandVar143)); //IsContext = False IsNew = False
				OperandVar145 = prop144;
				if(ifResult141 = !(OperandVar145))
				{
					applicable = true;
					OperandVar146 = applicable;
				}
			}
			return (System.Boolean) (OperandVar146);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.aged_generation>();
			Entity EntVar147 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar147 != null) EntVar147.ComponentAdded();
		}
        }
    }
    
    public class historical_persons : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar157 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable148 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable148 != null)
			{
				Lore StoredVariable149 = ((Lore)StoredVariable148.GetComponent(typeof(Lore))); //IsContext = False IsNew = False
				if(StoredVariable149 != null)
				{
					Place StoredVariable150 = ((Place)StoredVariable149.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable150 != null)
					{
						System.Boolean ifResult151; //IsContext = False IsNew = False
						
						
						System.Collections.Generic.List<Agent> OperandVar153 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
						System.Collections.Generic.List<Agent> prop152 = StoredVariable150.Agents; //IsContext = False IsNew = False
						if(prop152 != null)
						{
							OperandVar153 = prop152;
						}
						
						
						
						System.Boolean OperandVar156 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar154 = default(System.String); //IsContext = False IsNew = False
						OperandVar154 = "lore_pool";
						System.Boolean prop155 = StoredVariable148.HasMarker( (OperandVar154)); //IsContext = False IsNew = False
						OperandVar156 = prop155;
						if(ifResult151 = ( (( ( (OperandVar153 != null ? OperandVar153.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar156))))
						{
							applicable = true;
							OperandVar157 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar157);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Place subContext158 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext158 ContextSwitchInterpreter
				if(subContext158 != null)
				{
					
					subContext158.Size = (System.Int32)( (10f));
					System.Single OperandVar160 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop159 = External.Random( (4f), (10f)); //IsContext = False IsNew = False
					OperandVar160 = prop159;
					for (int i = 0; i <  (OperandVar160); i++)
					{
						UnityEngine.GameObject old_ag = new UnityEngine.GameObject("old_ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject old_ag161 = old_ag; //IsContext = True IsNew = False
							Entity AddContext162 = (Entity)old_ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							Agent AddContext163 = (Agent)old_ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.historical_person AddContext164 = (Blackboards.historical_person)old_ag.AddComponent(typeof(Blackboards.historical_person)); //IsContext = True IsNew = True
							Blackboards.human AddContext165 = (Blackboards.human)old_ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Blackboards.human AddContext165 ContextSwitchInterpreter
								if(AddContext165 != null)
								{
									System.Single OperandVar167 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop166 = External.Random( (30f), (45f)); //IsContext = False IsNew = False
									OperandVar167 = prop166;
									AddContext165.Age = (System.Int32)( (OperandVar167));
								}
							}
							Named AddContext168 = (Named)old_ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext168 ContextSwitchInterpreter
								if(AddContext168 != null)
								{
									
									
									
									AddContext168.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Historical person: ")).ToString());
									
									
									System.String OperandVar171 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar169 = default(System.String); //IsContext = False IsNew = False
									OperandVar169 = "human_name";
									System.String prop170 = External.RandomName( (OperandVar169)); //IsContext = False IsNew = False
									if(prop170 != null)
									{
										OperandVar171 = prop170;
									}
									AddContext168.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar171)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(old_ag);
						Agent OperandVar173 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable172 = ((Agent)old_ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable172 != null)
						{
							OperandVar173 = StoredVariable172;
						}
						subContext158.Attach((Agent)( (OperandVar173)));
					}
				}
			}
		}
        }
    }
    
    public class change_name_historical_action : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar183 = default(System.Boolean); //IsContext = False IsNew = False
			Entity StoredVariable174 = ((Entity)root.GetComponent(typeof(Entity))); //IsContext = False IsNew = False
			if(StoredVariable174 != null)
			{
				Blackboards.historical_person StoredVariable175 = ((Blackboards.historical_person)StoredVariable174.GetComponent(typeof(Blackboards.historical_person))); //IsContext = False IsNew = False
				if(StoredVariable175 != null)
				{
					Named StoredVariable176 = ((Named)StoredVariable175.GetComponent(typeof(Named))); //IsContext = False IsNew = False
					if(StoredVariable176 != null)
					{
						Agent StoredVariable177 = ((Agent)StoredVariable176.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable177 != null)
						{
							System.Boolean ifResult178; //IsContext = False IsNew = False
							
							
							System.Boolean OperandVar180 = default(System.Boolean); //IsContext = False IsNew = False
							System.Boolean prop179 = StoredVariable177.Act; //IsContext = False IsNew = False
							OperandVar180 = prop179;
							
							
							
							System.Boolean OperandVar182 = default(System.Boolean); //IsContext = False IsNew = False
							if(StoredVariable174 != null)
							{
								System.Boolean prop181 = StoredVariable174.Dead; //IsContext = False IsNew = False
								OperandVar182 = prop181;
							}
							if(ifResult178 = ( (( ( (OperandVar180))) == ( ( (true))))) && ( (!(OperandVar182))))
							{
								applicable = true;
								OperandVar183 = applicable;
							}
						}
					}
				}
			}
			return (System.Boolean) (OperandVar183);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0.5f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Named subContext184 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext184 ContextSwitchInterpreter
				if(subContext184 != null)
				{
					
					System.String OperandVar187 = default(System.String); //IsContext = False IsNew = False
					System.String OperandVar185 = default(System.String); //IsContext = False IsNew = False
					OperandVar185 = "human_name";
					System.String prop186 = External.RandomName( (OperandVar185)); //IsContext = False IsNew = False
					if(prop186 != null)
					{
						OperandVar187 = prop186;
					}
					subContext184.Switch(( ("main_name")).ToString(),( (OperandVar187)).ToString());
				}
			}
		}
        }
    }
    
    public class location_log : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar193 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable188 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable188 != null)
			{
				Named StoredVariable189 = ((Named)StoredVariable188.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable189 != null)
				{
					System.Boolean ifResult190; //IsContext = False IsNew = False
					
					System.Boolean OperandVar192 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable188 != null)
					{
						System.Boolean prop191 = StoredVariable188.Act; //IsContext = False IsNew = False
						OperandVar192 = prop191;
					}
					
					
					if(ifResult190 = ( ( (OperandVar192))) == ( ( (true))))
					{
						applicable = true;
						OperandVar193 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar193);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0.3f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			System.String OperandVar197 = default(System.String); //IsContext = False IsNew = False
			Named StoredVariable194 = ((Named)root.GetComponent(typeof(Named))); //IsContext = False IsNew = False
			if(StoredVariable194 != null)
			{
				System.String OperandVar195 = default(System.String); //IsContext = False IsNew = False
				OperandVar195 = "main_name";
				System.String prop196 = StoredVariable194.Get( (OperandVar195)); //IsContext = False IsNew = False
				if(prop196 != null)
				{
					OperandVar197 = prop196;
				}
			}
			External.Log((System.Object)( (OperandVar197)));
		}
        }
    }
    
    public class destroy_self : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar205 = default(System.Boolean); //IsContext = False IsNew = False
			Entity StoredVariable198 = ((Entity)root.GetComponent(typeof(Entity))); //IsContext = False IsNew = False
			if(StoredVariable198 != null)
			{
				Agent StoredVariable199 = ((Agent)StoredVariable198.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
				if(StoredVariable199 != null)
				{
					System.Boolean ifResult200; //IsContext = False IsNew = False
					
					
					System.Boolean OperandVar202 = default(System.Boolean); //IsContext = False IsNew = False
					System.Boolean prop201 = StoredVariable199.Act; //IsContext = False IsNew = False
					OperandVar202 = prop201;
					
					
					
					System.Boolean OperandVar204 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable198 != null)
					{
						System.Boolean prop203 = StoredVariable198.Dead; //IsContext = False IsNew = False
						OperandVar204 = prop203;
					}
					if(ifResult200 = ( (( ( (OperandVar202))) == ( ( (true))))) && ( (!(OperandVar204))))
					{
						applicable = true;
						OperandVar205 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar205);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0.01f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			
			
			UnityEngine.GameObject OperandVar206 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar206 = root;
			External.Log((System.Object)(( ( ("Destroying self "))) + ( ( (OperandVar206)))));
			UnityEngine.GameObject OperandVar207 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar207 = root;
			External.Destroy((UnityEngine.Object)( (OperandVar207)));
		}
        }
    }
    
    public class story_start : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar216 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable208 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable208 != null)
			{
				System.Boolean ifResult209; //IsContext = False IsNew = False
				
				System.Boolean OperandVar212 = default(System.Boolean); //IsContext = False IsNew = False
				System.String OperandVar210 = default(System.String); //IsContext = False IsNew = False
				OperandVar210 = "init_node";
				System.Boolean prop211 = StoredVariable208.HasMarker( (OperandVar210)); //IsContext = False IsNew = False
				OperandVar212 = prop211;
				
				System.Boolean OperandVar215 = default(System.Boolean); //IsContext = False IsNew = False
				System.String OperandVar213 = default(System.String); //IsContext = False IsNew = False
				OperandVar213 = "story_set";
				System.Boolean prop214 = StoredVariable208.HasMarker( (OperandVar213)); //IsContext = False IsNew = False
				OperandVar215 = prop214;
				if(ifResult209 = ( ( (OperandVar212))) && ( (!(OperandVar215))))
				{
					applicable = true;
					OperandVar216 = applicable;
				}
			}
			return (System.Boolean) (OperandVar216);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext217 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext217 ContextSwitchInterpreter
				if(subContext217 != null)
				{
					System.String OperandVar218 = default(System.String); //IsContext = False IsNew = False
					OperandVar218 = "story_set";
					subContext217.SetMarker(( (OperandVar218)).ToString());
				}
			}
			UnityEngine.GameObject s_node = new UnityEngine.GameObject("s_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject s_node219 = s_node; //IsContext = True IsNew = False
				TaleNode AddContext220 = (TaleNode)s_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.story_node AddContext221 = (Blackboards.story_node)s_node.AddComponent(typeof(Blackboards.story_node)); //IsContext = True IsNew = True
				Entity AddContext222 = (Entity)s_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Markers AddContext223 = (Markers)s_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(s_node);
			
			{
				UnityEngine.GameObject subContext224 = s_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext224 ContextPropertySwitchInterpreter
				if(subContext224 != null)
				{
					
					{
						TaleNode subContext225 = (TaleNode)subContext224.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext225 ContextSwitchInterpreter
						if(subContext225 != null)
						{
							
							subContext225.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
		}
        }
    }
    
    public class story_basic_decomposition : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar235 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable226 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable226 != null)
			{
				Blackboards.story_node StoredVariable227 = ((Blackboards.story_node)StoredVariable226.GetComponent(typeof(Blackboards.story_node))); //IsContext = False IsNew = False
				if(StoredVariable227 != null)
				{
					TaleNode StoredVariable228 = ((TaleNode)StoredVariable227.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
					if(StoredVariable228 != null)
					{
						System.Boolean ifResult229; //IsContext = False IsNew = False
						
						System.Boolean OperandVar232 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar230 = default(System.String); //IsContext = False IsNew = False
						OperandVar230 = "decomposed";
						System.Boolean prop231 = StoredVariable226.HasMarker( (OperandVar230)); //IsContext = False IsNew = False
						OperandVar232 = prop231;
						
						System.Boolean OperandVar234 = default(System.Boolean); //IsContext = False IsNew = False
						System.Boolean prop233 = StoredVariable228.IsActive; //IsContext = False IsNew = False
						OperandVar234 = prop233;
						if(ifResult229 = ( (!(OperandVar232))) && ( ( (OperandVar234))))
						{
							applicable = true;
							OperandVar235 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar235);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext236 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext236 ContextSwitchInterpreter
				if(subContext236 != null)
				{
					System.String OperandVar237 = default(System.String); //IsContext = False IsNew = False
					OperandVar237 = "decomposed";
					subContext236.SetMarker(( (OperandVar237)).ToString());
				}
			}
			UnityEngine.GameObject c_node = new UnityEngine.GameObject("c_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject c_node238 = c_node; //IsContext = True IsNew = False
				Markers AddContext239 = (Markers)c_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext240 = (TaleNode)c_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Entity AddContext241 = (Entity)c_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Blackboards.conflict_node AddContext242 = (Blackboards.conflict_node)c_node.AddComponent(typeof(Blackboards.conflict_node)); //IsContext = True IsNew = True
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(c_node);
			UnityEngine.GameObject c_r_node = new UnityEngine.GameObject("c_r_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject c_r_node243 = c_r_node; //IsContext = True IsNew = False
				Markers AddContext244 = (Markers)c_r_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext245 = (TaleNode)c_r_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Entity AddContext246 = (Entity)c_r_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Blackboards.conflict_resolution_node AddContext247 = (Blackboards.conflict_resolution_node)c_r_node.AddComponent(typeof(Blackboards.conflict_resolution_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.conflict_resolution_node AddContext247 ContextSwitchInterpreter
					if(AddContext247 != null)
					{
						UnityEngine.GameObject OperandVar248 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar248 = c_node;
						AddContext247.Conflict = (UnityEngine.GameObject)( (OperandVar248));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(c_r_node);
			UnityEngine.GameObject r_node = new UnityEngine.GameObject("r_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject r_node249 = r_node; //IsContext = True IsNew = False
				Markers AddContext250 = (Markers)r_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext251 = (TaleNode)r_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.result_node AddContext252 = (Blackboards.result_node)r_node.AddComponent(typeof(Blackboards.result_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.result_node AddContext252 ContextSwitchInterpreter
					if(AddContext252 != null)
					{
						UnityEngine.GameObject OperandVar253 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar253 = c_r_node;
						AddContext252.Resolution = (UnityEngine.GameObject)( (OperandVar253));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(r_node);
			UnityEngine.GameObject s_node = new UnityEngine.GameObject("s_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject s_node254 = s_node; //IsContext = True IsNew = False
				Markers AddContext255 = (Markers)s_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				Entity AddContext256 = (Entity)s_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				TaleNode AddContext257 = (TaleNode)s_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.solution_node AddContext258 = (Blackboards.solution_node)s_node.AddComponent(typeof(Blackboards.solution_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.solution_node AddContext258 ContextSwitchInterpreter
					if(AddContext258 != null)
					{
						UnityEngine.GameObject OperandVar259 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar259 = c_r_node;
						AddContext258.Cause = (UnityEngine.GameObject)( (OperandVar259));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(s_node);
			UnityEngine.GameObject cris_node = new UnityEngine.GameObject("cris_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject cris_node260 = cris_node; //IsContext = True IsNew = False
				Entity AddContext261 = (Entity)cris_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Markers AddContext262 = (Markers)cris_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext263 = (TaleNode)cris_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.crisis_node AddContext264 = (Blackboards.crisis_node)cris_node.AddComponent(typeof(Blackboards.crisis_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.crisis_node AddContext264 ContextSwitchInterpreter
					if(AddContext264 != null)
					{
						UnityEngine.GameObject OperandVar265 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar265 = s_node;
						AddContext264.Solution = (UnityEngine.GameObject)( (OperandVar265));
						UnityEngine.GameObject OperandVar266 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar266 = r_node;
						AddContext264.Cause = (UnityEngine.GameObject)( (OperandVar266));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(cris_node);
			
			{
				UnityEngine.GameObject subContext267 = c_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext267 ContextPropertySwitchInterpreter
				if(subContext267 != null)
				{
					
					{
						TaleNode subContext268 = (TaleNode)subContext267.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext268 ContextSwitchInterpreter
						if(subContext268 != null)
						{
							
							subContext268.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext269 = c_r_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext269 ContextPropertySwitchInterpreter
				if(subContext269 != null)
				{
					
					{
						TaleNode subContext270 = (TaleNode)subContext269.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext270 ContextSwitchInterpreter
						if(subContext270 != null)
						{
							
							subContext270.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext271 = r_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext271 ContextPropertySwitchInterpreter
				if(subContext271 != null)
				{
					
					{
						TaleNode subContext272 = (TaleNode)subContext271.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext272 ContextSwitchInterpreter
						if(subContext272 != null)
						{
							
							subContext272.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext273 = s_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext273 ContextPropertySwitchInterpreter
				if(subContext273 != null)
				{
					
					{
						TaleNode subContext274 = (TaleNode)subContext273.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext274 ContextSwitchInterpreter
						if(subContext274 != null)
						{
							
							subContext274.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext275 = cris_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext275 ContextPropertySwitchInterpreter
				if(subContext275 != null)
				{
					
					{
						TaleNode subContext276 = (TaleNode)subContext275.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext276 ContextSwitchInterpreter
						if(subContext276 != null)
						{
							
							subContext276.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
		}
        }
    }
    
    public class conflict_basic_decomposition : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar286 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable277 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable277 != null)
			{
				Blackboards.conflict_node StoredVariable278 = ((Blackboards.conflict_node)StoredVariable277.GetComponent(typeof(Blackboards.conflict_node))); //IsContext = False IsNew = False
				if(StoredVariable278 != null)
				{
					TaleNode StoredVariable279 = ((TaleNode)StoredVariable278.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
					if(StoredVariable279 != null)
					{
						System.Boolean ifResult280; //IsContext = False IsNew = False
						
						System.Boolean OperandVar283 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar281 = default(System.String); //IsContext = False IsNew = False
						OperandVar281 = "decomposed";
						System.Boolean prop282 = StoredVariable277.HasMarker( (OperandVar281)); //IsContext = False IsNew = False
						OperandVar283 = prop282;
						
						System.Boolean OperandVar285 = default(System.Boolean); //IsContext = False IsNew = False
						System.Boolean prop284 = StoredVariable279.IsActive; //IsContext = False IsNew = False
						OperandVar285 = prop284;
						if(ifResult280 = ( (!(OperandVar283))) && ( ( (OperandVar285))))
						{
							applicable = true;
							OperandVar286 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar286);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			for (int i = 0; i <  (2f); i++)
			{
				UnityEngine.GameObject f_node = new UnityEngine.GameObject("f_node"); //IsContext = False IsNew = False
				
				{
					UnityEngine.GameObject f_node287 = f_node; //IsContext = True IsNew = False
					TaleNode AddContext288 = (TaleNode)f_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
					Entity AddContext289 = (Entity)f_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
					Blackboards.faction_node AddContext290 = (Blackboards.faction_node)f_node.AddComponent(typeof(Blackboards.faction_node)); //IsContext = True IsNew = True
					
					{
						//ContextStatement Blackboards.faction_node AddContext290 ContextSwitchInterpreter
						if(AddContext290 != null)
						{
							UnityEngine.GameObject OperandVar291 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							OperandVar291 = root;
							AddContext290.Conflict = (UnityEngine.GameObject)( (OperandVar291));
						}
					}
					Markers AddContext292 = (Markers)f_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				}
				UnityEngine.Object.FindObjectOfType<Generators>().Generate(f_node);
				
				{
					UnityEngine.GameObject subContext293 = f_node; //IsContext = True IsNew = False
					//ContextStatement UnityEngine.GameObject subContext293 ContextPropertySwitchInterpreter
					if(subContext293 != null)
					{
						
						{
							TaleNode subContext294 = (TaleNode)subContext293.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
							//ContextStatement TaleNode subContext294 ContextSwitchInterpreter
							if(subContext294 != null)
							{
								
								subContext294.IsActive = (System.Boolean)( (true));
							}
						}
					}
				}
			}
			
			{
				Markers subContext295 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext295 ContextSwitchInterpreter
				if(subContext295 != null)
				{
					System.String OperandVar296 = default(System.String); //IsContext = False IsNew = False
					OperandVar296 = "decomposed";
					subContext295.SetMarker(( (OperandVar296)).ToString());
				}
			}
		}
        }
    }
    
    public class tale_ui_enlisting : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar303 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable297 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable297 != null)
			{
				TaleNode StoredVariable298 = ((TaleNode)StoredVariable297.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
				if(StoredVariable298 != null)
				{
					System.Boolean ifResult299; //IsContext = False IsNew = False
					System.Boolean OperandVar302 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar300 = default(System.String); //IsContext = False IsNew = False
					OperandVar300 = "tale_enlisted";
					System.Boolean prop301 = StoredVariable297.HasMarker( (OperandVar300)); //IsContext = False IsNew = False
					OperandVar302 = prop301;
					if(ifResult299 = !(OperandVar302))
					{
						applicable = true;
						OperandVar303 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar303);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject ui = new UnityEngine.GameObject("ui"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject ui304 = ui; //IsContext = True IsNew = False
				UiObject AddContext305 = (UiObject)ui.AddComponent(typeof(UiObject)); //IsContext = True IsNew = True
				
				{
					//ContextStatement UiObject AddContext305 ContextSwitchInterpreter
					if(AddContext305 != null)
					{
						UnityEngine.GameObject OperandVar306 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar306 = root;
						AddContext305.ShowedObject = (UnityEngine.GameObject)( (OperandVar306));
					}
				}
				TextField AddContext307 = (TextField)ui.AddComponent(typeof(TextField)); //IsContext = True IsNew = True
				
				{
					//ContextStatement TextField AddContext307 ContextSwitchInterpreter
					if(AddContext307 != null)
					{
						
						{
							UnityEngine.UI.LayoutElement subContext308 = AddContext307.Layout; //IsContext = True IsNew = False
							//ContextStatement UnityEngine.UI.LayoutElement subContext308 ContextPropertySwitchInterpreter
							if(subContext308 != null)
							{
								
								subContext308.minHeight = (System.Single)( (20f));
							}
						}
						System.String OperandVar311 = default(System.String); //IsContext = False IsNew = False
						UnityEngine.GameObject OperandVar309 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar309 = root;
						System.String prop310 = External.Stringify( (OperandVar309)); //IsContext = False IsNew = False
						if(prop310 != null)
						{
							OperandVar311 = prop310;
						}
						AddContext307.Show(( (OperandVar311)).ToString());
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(ui);
			UnityEngine.GameObject OperandVar312 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar312 = ui;
			External.TalesUiEnlist((UnityEngine.GameObject)( (OperandVar312)));
			
			{
				Markers subContext313 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext313 ContextSwitchInterpreter
				if(subContext313 != null)
				{
					System.String OperandVar314 = default(System.String); //IsContext = False IsNew = False
					OperandVar314 = "tale_enlisted";
					subContext313.SetUiMarker(( (OperandVar314)).ToString());
				}
			}
		}
        }
    }
    
    public class faction_is_a_state : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar321 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.faction_node StoredVariable315 = ((Blackboards.faction_node)root.GetComponent(typeof(Blackboards.faction_node))); //IsContext = False IsNew = False
			if(StoredVariable315 != null)
			{
				Markers StoredVariable316 = ((Markers)StoredVariable315.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable316 != null)
				{
					System.Boolean ifResult317; //IsContext = False IsNew = False
					System.Boolean OperandVar320 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar318 = default(System.String); //IsContext = False IsNew = False
					OperandVar318 = "faction_is_a_state";
					System.Boolean prop319 = StoredVariable316.HasMarker( (OperandVar318)); //IsContext = False IsNew = False
					OperandVar320 = prop319;
					if(ifResult317 = !(OperandVar320))
					{
						applicable = true;
						OperandVar321 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar321);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.state_node>();
			Entity EntVar322 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar322 != null) EntVar322.ComponentAdded();
			
			{
				Markers subContext323 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext323 ContextSwitchInterpreter
				if(subContext323 != null)
				{
					System.String OperandVar324 = default(System.String); //IsContext = False IsNew = False
					OperandVar324 = "faction_is_a_state";
					subContext323.SetMarker(( (OperandVar324)).ToString());
				}
			}
		}
        }
    }
    
    public class state_name : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar331 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.state_node StoredVariable325 = ((Blackboards.state_node)root.GetComponent(typeof(Blackboards.state_node))); //IsContext = False IsNew = False
			if(StoredVariable325 != null)
			{
				System.Boolean ifResult326; //IsContext = False IsNew = False
				System.Boolean OperandVar330 = default(System.Boolean); //IsContext = False IsNew = False
				Named OperandVar328 = default(Named); //IsContext = False IsNew = False
				Named StoredVariable327 = ((Named)StoredVariable325.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable327 != null)
				{
					OperandVar328 = StoredVariable327;
				}
				System.Boolean prop329 = External.Has( (OperandVar328)); //IsContext = False IsNew = False
				OperandVar330 = prop329;
				if(ifResult326 = !(OperandVar330))
				{
					applicable = true;
					OperandVar331 = applicable;
				}
			}
			return (System.Boolean) (OperandVar331);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			Named ContextVar332 = root.AddComponent<Named>();; //IsContext = False IsNew = True
			
			{
				//ContextStatement Named ContextVar332 ContextSwitchInterpreter
				if(ContextVar332 != null)
				{
					
					
					System.String OperandVar335 = default(System.String); //IsContext = False IsNew = False
					System.String OperandVar333 = default(System.String); //IsContext = False IsNew = False
					OperandVar333 = "country_name";
					System.String prop334 = External.RandomName( (OperandVar333)); //IsContext = False IsNew = False
					if(prop334 != null)
					{
						OperandVar335 = prop334;
					}
					ContextVar332.Set(( ("main_name")).ToString(),(System.Single)( (0f)),( (OperandVar335)).ToString());
				}
			}
			Entity EntVar336 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar336 != null) EntVar336.ComponentAdded();
		}
        }
    }
    
    public class state_head : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar346 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.state_node StoredVariable337 = ((Blackboards.state_node)root.GetComponent(typeof(Blackboards.state_node))); //IsContext = False IsNew = False
			if(StoredVariable337 != null)
			{
				TaleNode StoredVariable338 = ((TaleNode)StoredVariable337.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
				if(StoredVariable338 != null)
				{
					System.Boolean ifResult339; //IsContext = False IsNew = False
					
					System.Boolean OperandVar343 = default(System.Boolean); //IsContext = False IsNew = False
					UnityEngine.GameObject OperandVar341 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					if(StoredVariable337 != null)
					{
						UnityEngine.GameObject prop340 = StoredVariable337.Head; //IsContext = False IsNew = False
						if(prop340 != null)
						{
							OperandVar341 = prop340;
						}
					}
					System.Boolean prop342 = External.Has( (OperandVar341)); //IsContext = False IsNew = False
					OperandVar343 = prop342;
					
					System.Boolean OperandVar345 = default(System.Boolean); //IsContext = False IsNew = False
					System.Boolean prop344 = StoredVariable338.IsActive; //IsContext = False IsNew = False
					OperandVar345 = prop344;
					if(ifResult339 = ( (!(OperandVar343))) && ( ( (OperandVar345))))
					{
						applicable = true;
						OperandVar346 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar346);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Blackboards.state_node subContext347 = (Blackboards.state_node)root.GetComponent(typeof(Blackboards.state_node)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.state_node subContext347 ContextSwitchInterpreter
				if(subContext347 != null)
				{
					UnityEngine.GameObject head_of_state = new UnityEngine.GameObject("head_of_state"); //IsContext = False IsNew = False
					
					{
						UnityEngine.GameObject head_of_state348 = head_of_state; //IsContext = True IsNew = False
						Markers AddContext349 = (Markers)head_of_state.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
						Blackboards.person_node AddContext350 = (Blackboards.person_node)head_of_state.AddComponent(typeof(Blackboards.person_node)); //IsContext = True IsNew = True
						TaleNode AddContext351 = (TaleNode)head_of_state.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
						Blackboards.head_of_state_node AddContext352 = (Blackboards.head_of_state_node)head_of_state.AddComponent(typeof(Blackboards.head_of_state_node)); //IsContext = True IsNew = True
						
						{
							//ContextStatement Blackboards.head_of_state_node AddContext352 ContextSwitchInterpreter
							if(AddContext352 != null)
							{
								UnityEngine.GameObject OperandVar353 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar353 = root;
								AddContext352.State = (UnityEngine.GameObject)( (OperandVar353));
							}
						}
						Entity AddContext354 = (Entity)head_of_state.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
					}
					UnityEngine.Object.FindObjectOfType<Generators>().Generate(head_of_state);
					
					{
						UnityEngine.GameObject subContext355 = head_of_state; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext355 ContextPropertySwitchInterpreter
						if(subContext355 != null)
						{
							
							{
								TaleNode subContext356 = (TaleNode)subContext355.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
								//ContextStatement TaleNode subContext356 ContextSwitchInterpreter
								if(subContext356 != null)
								{
									
									subContext356.IsActive = (System.Boolean)( (true));
								}
							}
						}
					}
					UnityEngine.GameObject OperandVar357 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar357 = head_of_state;
					subContext347.Head = (UnityEngine.GameObject)( (OperandVar357));
				}
			}
		}
        }
    }
    
    public class state_head_death : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar372 = default(System.Boolean); //IsContext = False IsNew = False
			Event StoredVariable358 = ((Event)root.GetComponent(typeof(Event))); //IsContext = False IsNew = False
			if(StoredVariable358 != null)
			{
				Markers StoredVariable359 = ((Markers)StoredVariable358.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable359 != null)
				{
					EntityDeathEvent StoredVariable360 = ((EntityDeathEvent)StoredVariable359.GetComponent(typeof(EntityDeathEvent))); //IsContext = False IsNew = False
					if(StoredVariable360 != null)
					{
						System.Boolean ifResult361; //IsContext = False IsNew = False
						
						System.Boolean OperandVar368 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable358 != null)
						{
							UnityEngine.GameObject prop362 = StoredVariable358.Context; //IsContext = False IsNew = False
							if(prop362 != null)
							{
								System.Boolean ifResult363; //IsContext = False IsNew = False
								System.Boolean OperandVar367 = default(System.Boolean); //IsContext = False IsNew = False
								Blackboards.head_of_state_node OperandVar365 = default(Blackboards.head_of_state_node); //IsContext = False IsNew = False
								Blackboards.head_of_state_node StoredVariable364 = ((Blackboards.head_of_state_node)prop362.GetComponent(typeof(Blackboards.head_of_state_node))); //IsContext = False IsNew = False
								if(StoredVariable364 != null)
								{
									OperandVar365 = StoredVariable364;
								}
								System.Boolean prop366 = External.Has( (OperandVar365)); //IsContext = False IsNew = False
								OperandVar367 = prop366;
								if(ifResult363 =  (OperandVar367))
								{
									OperandVar368 = ifResult363;
								}
							}
						}
						
						System.Boolean OperandVar371 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar369 = default(System.String); //IsContext = False IsNew = False
						OperandVar369 = "state_head_death_reacted";
						System.Boolean prop370 = StoredVariable359.HasMarker( (OperandVar369)); //IsContext = False IsNew = False
						OperandVar371 = prop370;
						if(ifResult361 = ( ( (OperandVar368))) && ( (!(OperandVar371))))
						{
							applicable = true;
							OperandVar372 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar372);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext373 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext373 ContextSwitchInterpreter
				if(subContext373 != null)
				{
					System.String OperandVar374 = default(System.String); //IsContext = False IsNew = False
					OperandVar374 = "state_head_death_reacted";
					subContext373.SetMarker(( (OperandVar374)).ToString());
				}
			}
			
			{
				Event subContext375 = (Event)root.GetComponent(typeof(Event)); //IsContext = True IsNew = False
				//ContextStatement Event subContext375 ContextSwitchInterpreter
				if(subContext375 != null)
				{
					
					{
						UnityEngine.GameObject subContext376 = subContext375.Context; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext376 ContextPropertySwitchInterpreter
						if(subContext376 != null)
						{
							
							{
								Blackboards.head_of_state_node subContext377 = (Blackboards.head_of_state_node)subContext376.GetComponent(typeof(Blackboards.head_of_state_node)); //IsContext = True IsNew = False
								//ContextStatement Blackboards.head_of_state_node subContext377 ContextSwitchInterpreter
								if(subContext377 != null)
								{
								}
							}
						}
					}
				}
			}
		}
        }
    }
    
    public class state_head_name : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar384 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.head_of_state_node StoredVariable378 = ((Blackboards.head_of_state_node)root.GetComponent(typeof(Blackboards.head_of_state_node))); //IsContext = False IsNew = False
			if(StoredVariable378 != null)
			{
				System.Boolean ifResult379; //IsContext = False IsNew = False
				System.Boolean OperandVar383 = default(System.Boolean); //IsContext = False IsNew = False
				Named OperandVar381 = default(Named); //IsContext = False IsNew = False
				Named StoredVariable380 = ((Named)StoredVariable378.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable380 != null)
				{
					OperandVar381 = StoredVariable380;
				}
				System.Boolean prop382 = External.Has( (OperandVar381)); //IsContext = False IsNew = False
				OperandVar383 = prop382;
				if(ifResult379 = !(OperandVar383))
				{
					applicable = true;
					OperandVar384 = applicable;
				}
			}
			return (System.Boolean) (OperandVar384);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			Named ContextVar385 = root.AddComponent<Named>();; //IsContext = False IsNew = True
			
			{
				//ContextStatement Named ContextVar385 ContextSwitchInterpreter
				if(ContextVar385 != null)
				{
					System.String OperandVar386 = default(System.String); //IsContext = False IsNew = False
					OperandVar386 = "main_name";
					
					System.String OperandVar389 = default(System.String); //IsContext = False IsNew = False
					System.String OperandVar387 = default(System.String); //IsContext = False IsNew = False
					OperandVar387 = "human_name";
					System.String prop388 = External.RandomName( (OperandVar387)); //IsContext = False IsNew = False
					if(prop388 != null)
					{
						OperandVar389 = prop388;
					}
					ContextVar385.Set(( (OperandVar386)).ToString(),(System.Single)( (0f)),( (OperandVar389)).ToString());
				}
			}
			Entity EntVar390 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar390 != null) EntVar390.ComponentAdded();
		}
        }
    }
    
    public class map_anchored : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar400 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable391 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable391 != null)
			{
				Markers StoredVariable392 = ((Markers)StoredVariable391.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable392 != null)
				{
					System.Boolean ifResult393; //IsContext = False IsNew = False
					
					System.Boolean OperandVar396 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar394 = default(System.String); //IsContext = False IsNew = False
					OperandVar394 = "map_anchored";
					System.Boolean prop395 = StoredVariable392.HasMarker( (OperandVar394)); //IsContext = False IsNew = False
					OperandVar396 = prop395;
					
					System.Boolean OperandVar399 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar397 = default(System.String); //IsContext = False IsNew = False
					OperandVar397 = "history_place";
					System.Boolean prop398 = StoredVariable392.HasMarker( (OperandVar397)); //IsContext = False IsNew = False
					OperandVar399 = prop398;
					if(ifResult393 = ( (!(OperandVar396))) && ( ( (OperandVar399))))
					{
						applicable = true;
						OperandVar400 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar400);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext401 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext401 ContextSwitchInterpreter
				if(subContext401 != null)
				{
					System.String OperandVar402 = default(System.String); //IsContext = False IsNew = False
					OperandVar402 = "map_anchored";
					subContext401.SetUiMarker(( (OperandVar402)).ToString());
				}
			}
			UnityEngine.GameObject OperandVar403 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar403 = root;
			External.MapEnlist((UnityEngine.GameObject)( (OperandVar403)));
		}
        }
    }
}
